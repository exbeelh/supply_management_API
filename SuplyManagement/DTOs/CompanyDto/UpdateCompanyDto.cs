namespace SuplyManagement.DTOs.CompanyDto
{
    public class UpdateCompanyDto
    {
        public string CompanyId { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string CompanyPhone { get; set; } = null!;
        public string? Photo { get; set; }
    }
}
