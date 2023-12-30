using SuplyManagement.Contexts;
using SuplyManagement.Models;

namespace SuplyManagement.Repositories
{
    public class CompanyRepository : GeneralRepository<TbCompany>
    {
        public CompanyRepository(SuplyManagementContext context) : base(context)
        {
        }
    }
}
