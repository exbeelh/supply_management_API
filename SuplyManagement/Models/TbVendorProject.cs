using SuplyManagement.Utilities.Enums;
using System;
using System.Collections.Generic;

namespace SuplyManagement.Models;

public partial class TbVendorProject
{
    public string VendorProjectId { get; set; } = null!;

    public string? VendorId { get; set; }

    public string? ProjectId { get; set; }

    public ApprovalStatus SubmissionStatus { get; set; }

    public virtual TbProject? Project { get; set; }

    public virtual TbVendorDetail? Vendor { get; set; }
}
