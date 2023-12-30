using SuplyManagement.Utilities.Enums;

namespace SuplyManagement.Models;

public partial class TbProject
{
    public string ProjectId { get; set; } = null!;

    public string ProjectName { get; set; } = null!;

    public string? ProjectDescription { get; set; }

    public ProjectStatus SubmissionStatus { get; set; }

    public virtual ICollection<TbVendorProject> TbVendorProjects { get; } = new List<TbVendorProject>();
}
