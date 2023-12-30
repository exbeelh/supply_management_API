using SuplyManagement.Utilities.Enums;
using System;
using System.Collections.Generic;

namespace SuplyManagement.Models;

public partial class TbVendorDetail
{
    public string VendorId { get; set; } = null!;

    public int BusinessField { get; set; }

    public int CompanyType { get; set; }

    public ApprovalStatus ApprovalStatus { get; set; }

    public virtual TbBusinessField BusinessFieldNavigation { get; set; } = null!;

    public virtual TbCompaniesType CompanyTypeNavigation { get; set; } = null!;

    public virtual ICollection<TbApprovalHistory> TbApprovalHistories { get; } = new List<TbApprovalHistory>();

    public virtual ICollection<TbVendorProject> TbVendorProjects { get; } = new List<TbVendorProject>();

    public virtual TbCompany Vendor { get; set; } = null!;
}
