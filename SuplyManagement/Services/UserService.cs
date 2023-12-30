using SuplyManagement.Contracts;
using SuplyManagement.DTOs.UserDto;
using SuplyManagement.Utilities.Handlers;

namespace SuplyManagement.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public int RegisterUser(RegisterUserDto registerUser)
        {
            if (_userRepository.GetAll().Any(u => u.Email == registerUser.Email))
            {
                // Email is already registered
                return 0;
            }

            string hashedPassword = Hashing.HashPassword(registerUser.Password);

            var newUser = new RegisterUserDto
            {
                UserId = Guid.NewGuid().ToString(),
                FirstName = registerUser.FirstName,
                LastName = registerUser.LastName,
                Email = registerUser.Email,
                Password = hashedPassword
            };

            // Add the new user to the database
            _userRepository.Create(newUser);

            return 1;
        }

        public bool Login(LoginUserDto loginUser)
        {
            var getUserData = _userRepository
                .GetAll()
                .Where(user => user.Email == loginUser.Email)
                .Select(user => new LoginUserDto
                {
                    Email = user.Email,
                    Password = user.Password
                }).FirstOrDefault();

            return getUserData != null && Hashing.ValidatePassword(loginUser.Password, getUserData.Password);
        }

        public GetUserDto GetUserData(string email)
        {
            var getUserData = _userRepository
                .GetAll()
                .Where(user => user.Email == email)
                .Select(user => new GetUserDto
                {
                    UserId = user.UserId,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email
                })
                .FirstOrDefault(ud => ud.Email == email);

            return getUserData!;
        }

        public GetUserRoleDto GetRoleByEmail(string email)
        {
            return _userRepository.GetAll()
                .Where(user => user.Email == email)
                .Select(user => new GetUserRoleDto { Role = user.Role })
                .FirstOrDefault()!;

        }
    }
}
