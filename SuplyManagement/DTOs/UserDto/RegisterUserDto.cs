using SuplyManagement.Models;
using SuplyManagement.Utilities.Enums;

namespace SuplyManagement.DTOs.UserDto
{
    public class RegisterUserDto
    {
        public String UserId { get; set; } = null!;
        public String FirstName { get; set; } = null!;
        public String? LastName { get; set; }
        public String Email { get; set; } = null!;
        public String Password { get; set; } = null!;
        public Role Role { get; set; }

        public static implicit operator TbUser(RegisterUserDto registerDto)
        {
            return new TbUser
            {
                FirstName = registerDto.FirstName,
                LastName = registerDto.LastName,
                Email = registerDto.Email,
                Password = registerDto.Password,
                Role = (Role)2
            };
        }

        public static explicit operator RegisterUserDto(TbUser user) 
        {
            return new RegisterUserDto
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Password = user.Password,
                Role = (Role)2
            };
        }
    }
}
