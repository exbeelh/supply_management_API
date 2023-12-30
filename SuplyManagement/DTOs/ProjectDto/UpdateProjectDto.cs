using SuplyManagement.Utilities.Enums;

namespace SuplyManagement.DTOs.ProjectDto
{
    public class UpdateProjectDto
    {
        public String ProjectId { get; set; } = null!;
        public String ProjectName { get; set; } = null!;
        public String Description { get; set; } = null!;
        public ProjectStatus Status { get; set; }
    }
}
