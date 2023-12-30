using Microsoft.AspNetCore.Mvc;
using SuplyManagement.DTOs.UserDto;
using SuplyManagement.Services;
using SuplyManagement.Utilities.Handlers;
using System.Net;
using System.Security.Claims;

namespace SuplyManagement.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        private readonly TokenService _tokenService;

        public UserController(UserService userService, TokenService tokenService)
        {
            _userService = userService;
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginUserDto loginUserDto)
        {
            try
            {
                var result = _userService.Login(loginUserDto);

                if (result is false)
                {
                    return BadRequest(new ResponseHandler<LoginUserDto>
                    {
                        Code = StatusCodes.Status400BadRequest,
                        Status = HttpStatusCode.BadRequest.ToString(),
                        Message = "Account Email or Password Does not Match!"
                    });
                }

                var userData = _userService.GetUserData(loginUserDto.Email);

                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Email, userData.Email),
                    new Claim(ClaimTypes.Name, userData.Email),
                    new Claim(ClaimTypes.NameIdentifier, userData.FullName),
                    new Claim("ID", userData.Id.ToString()),
                    new Claim("Picture", userData.Picture)
                };

                var getRoles = _userService.GetRoleByEmai(loginUserDto.Email);
                foreach (var item in getRoles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, item));
                }

                var accessToken = _tokenService.GenerateAccessToken(claims);
                var refreshToken = _tokenService.GenerateRefreshToken();

                var generatedToken = new TokenDto
                {
                    Token = accessToken,
                    RefreshToken = refreshToken,
                    TokenType = "Bearer"
                };

                return Ok(new
                {
                    code = StatusCodes.Status200OK,
                    status = HttpStatusCode.OK.ToString(),
                    message = "Login Succesfully!",
                    data = generatedToken
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                return BadRequest(new ResponseHandler<LoginUserDto>
                {
                    Code = StatusCodes.Status400BadRequest,
                    Status = HttpStatusCode.BadRequest.ToString(),
                    Message = "Something Wrong!"
                });
            }
        }
    }
}
