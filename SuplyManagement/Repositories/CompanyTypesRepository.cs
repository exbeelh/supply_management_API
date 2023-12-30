using SuplyManagement.Contexts;
using SuplyManagement.Models;

namespace SuplyManagement.Repositories
{
    public class CompanyTypesRepository : GeneralRepository<TbCompaniesType>
    {
        public CompanyTypesRepository(SuplyManagementContext context) : base(context)
        {
        }
    }
}
