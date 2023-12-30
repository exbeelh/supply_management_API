using SuplyManagement.Utilities.Enums;
using System;
using System.Collections.Generic;

namespace SuplyManagement.Models;

public partial class TbUser
{
    public string UserId { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public Role Role { get; set; }

    public virtual ICollection<TbApprovalHistory> TbApprovalHistories { get; } = new List<TbApprovalHistory>();

    public virtual TbCompany? TbCompany { get; set; }
}
