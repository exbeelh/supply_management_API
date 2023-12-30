using SuplyManagement.Contexts;
using SuplyManagement.Contracts;
using SuplyManagement.Models;

namespace SuplyManagement.Repositories
{
    public class BusinessFieldRepository : GeneralRepository<TbBusinessField>, IBusinessFieldRepository
    {
        public BusinessFieldRepository(SuplyManagementContext context) : base(context)
        {
        }
    }
}
