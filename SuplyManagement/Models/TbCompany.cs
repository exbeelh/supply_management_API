using SuplyManagement.Utilities.Enums;
using System;
using System.Collections.Generic;

namespace SuplyManagement.Models;

public partial class TbCompany
{
    public string CompanyId { get; set; } = null!;

    public string? UserId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public ApprovalStatus RegistrationStatus { get; set; }

    public string? Photo { get; set; }

    public virtual TbVendorDetail? TbVendorDetail { get; set; }

    public virtual TbUser? User { get; set; }
}
