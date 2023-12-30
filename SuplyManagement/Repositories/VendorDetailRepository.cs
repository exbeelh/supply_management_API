using SuplyManagement.Contexts;
using SuplyManagement.Contracts;
using SuplyManagement.Models;

namespace SuplyManagement.Repositories
{
    public class VendorDetailRepository : GeneralRepository<TbVendorDetail>, IVendorDetailRepository
    {
        public VendorDetailRepository(SuplyManagementContext context) : base(context)
        {
        }
    }
}
