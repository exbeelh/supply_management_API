namespace SuplyManagement.DTOs.ApprovalHistoryDto
{
    public class GetApprovalHistoryDto
    {
        public String ApprovalId { get; set; } = null!; 
        public String VendorId { get; set; } = null!;
        public String ApproverUserName { get; set; } = null!;
        public String ApprovalStatus { get; set; } = null!;
        public String ApprovalDate { get; set; } = null!;
    }
}
