using SuplyManagement.Utilities.Enums;

namespace SuplyManagement.DTOs.VendorDetailDto
{
    public class UpdateVendorDto
    {
        public String VendorId { get; set; } = null!;
        public ApprovalStatus ApprovalStatus { get; set; }
    }
}
