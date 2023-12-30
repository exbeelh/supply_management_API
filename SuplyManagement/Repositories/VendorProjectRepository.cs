using SuplyManagement.Contexts;
using SuplyManagement.Contracts;
using SuplyManagement.Models;

namespace SuplyManagement.Repositories
{
    public class VendorProjectRepository : GeneralRepository<TbVendorProject>, IVendorProjectRepository
    {
        public VendorProjectRepository(SuplyManagementContext context) : base(context)
        {
        }
    }
}
