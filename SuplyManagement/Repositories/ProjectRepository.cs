using SuplyManagement.Contexts;
using SuplyManagement.Contracts;
using SuplyManagement.Models;

namespace SuplyManagement.Repositories
{
    public class ProjectRepository : GeneralRepository<TbProject>, IProjectRepository
    {
        public ProjectRepository(SuplyManagementContext context) : base(context)
        {
        }
    }
}
