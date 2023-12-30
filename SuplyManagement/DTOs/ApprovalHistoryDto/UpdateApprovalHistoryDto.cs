namespace SuplyManagement.DTOs.ApprovalHistoryDto
{
    public class UpdateApprovalHistoryDto
    {
        public String ApprovalId { get; set; } = null!;
        public String VendorId { get; set; } = null!;
        public String ApproverUserId { get; set; } = null!;
        public String ApprovalStatus { get; set; } = null!;
        public String ApprovalDate { get; set; } = null!;
    }
}
