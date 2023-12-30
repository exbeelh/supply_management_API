using SuplyManagement.Utilities.Enums;

namespace SuplyManagement.DTOs.CompanyDto
{
    public class GetCompanyDto
    {
        public string CompanyId { get; set; } = null!;
        public string CompanyName { get; set;} = null!;
        public string CompanyEmail { get; set;} = null!;
        public string CompanyPhone { get; set; } = null!;
        public string? Photo { get; set; }
        public ApprovalStatus RegistrationStatus { get; set; }

    }
}
