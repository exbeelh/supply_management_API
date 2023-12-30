using SuplyManagement.Contexts;
using SuplyManagement.Contracts;
using SuplyManagement.Models;

namespace SuplyManagement.Repositories
{
    public class CompanyTypesRepository : GeneralRepository<TbCompaniesType>, ICompanyTypeRepository
    {
        public CompanyTypesRepository(SuplyManagementContext context) : base(context)
        {
        }
    }
}
