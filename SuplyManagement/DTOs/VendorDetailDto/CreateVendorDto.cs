namespace SuplyManagement.DTOs.VendorDetailDto
{
    public class CreateVendorDto
    {
        public String VendorId { get; set; } = null!;
        public int BusinessField { get; set; }
        public int CompanyType { get; set; }
    }
}
