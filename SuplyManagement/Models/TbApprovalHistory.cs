using System;
using System.Collections.Generic;

namespace SuplyManagement.Models;

public partial class TbApprovalHistory
{
    public string ApprovalId { get; set; } = null!;

    public string? VendorId { get; set; }

    public string? ApproverUserId { get; set; }

    public string ApprovalStatus { get; set; } = null!;

    public DateTime? ApprovalDate { get; set; }

    public virtual TbUser? ApproverUser { get; set; }

    public virtual TbVendorDetail? Vendor { get; set; }
}
