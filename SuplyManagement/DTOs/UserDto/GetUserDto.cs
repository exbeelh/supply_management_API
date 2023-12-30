using SuplyManagement.Models;
using SuplyManagement.Utilities.Enums;

namespace SuplyManagement.DTOs.UserDto
{
    public class GetUserDto
    {
        public String UserId { get; set; } = null!;
        public String FirstName { get; set; } = null!;
        public String? LastName { get; set; }
        public String Email { get; set; } = null!;

}
