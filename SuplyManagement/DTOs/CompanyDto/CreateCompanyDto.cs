namespace SuplyManagement.DTOs.CompanyDto
{
    public class CreateCompanyDto
    {
        public string CompanyId { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string CompanyEmail { get; set; } = null!;
        public string CompanyPhone { get; set; } = null!;
        public string? Photo { get; set; }
    }
}
