using System;
using System.Collections.Generic;

namespace SuplyManagement.Models;

public partial class TbBusinessField
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<TbVendorDetail> TbVendorDetails { get; } = new List<TbVendorDetail>();
}
