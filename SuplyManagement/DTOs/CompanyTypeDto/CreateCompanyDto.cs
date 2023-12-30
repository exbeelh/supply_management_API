using SuplyManagement.Utilities.Enums;

namespace SuplyManagement.DTOs.CompanyTypeDto
{
    public class CreateCompanyDto
    {
        public String CompanyId { get; set; } = null!;
        public String UserId { get; set; } = null!;
        public String CompanyName { get; set; } = null!;
        public String Email { get; set; } = null!;
        public String Phone { get; set; } = null!;
        public String? Photo { get; set; } = null!;
        public ApprovalStatus RegistrationStatus { get; set; }
    }
}
