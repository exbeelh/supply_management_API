using SuplyManagement.Contexts;
using SuplyManagement.Contracts;
using SuplyManagement.Models;

namespace SuplyManagement.Repositories
{
    public class CompanyRepository : GeneralRepository<TbCompany>, ICompanyRespository
    {
        public CompanyRepository(SuplyManagementContext context) : base(context)
        {
        }
    }
}
