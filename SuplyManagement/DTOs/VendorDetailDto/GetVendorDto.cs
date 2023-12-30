using SuplyManagement.Utilities.Enums;

namespace SuplyManagement.DTOs.VendorDetailDto
{
    public class GetVendorDto
    {
        public String VendorId { get; set; } = null!;
        public String VendorName { get; set; } = null!;
        public String BusinessField { get; set; } = null!;
        public String CompanyType { get; set; } = null!;
        public ApprovalStatus ApprovalStatus { get; set; }
    }
}
