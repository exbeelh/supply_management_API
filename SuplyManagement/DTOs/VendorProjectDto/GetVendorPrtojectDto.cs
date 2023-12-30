using SuplyManagement.Utilities.Enums;

namespace SuplyManagement.DTOs.VendorProjectDto
{
    public class GetVendorPrtojectDto
    {
        public String VendorProjcetId { get; set; } = null!;
        public String VendorId { get; set; } = null!;
        public String ProjectId { get; set;} = null!;
        public ApprovalStatus SubmissionStatus { get; set; }
    }
}
