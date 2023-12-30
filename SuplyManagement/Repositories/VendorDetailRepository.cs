using SuplyManagement.Contexts;
using SuplyManagement.Models;

namespace SuplyManagement.Repositories
{
    public class VendorDetailRepository : GeneralRepository<TbVendorDetail>
    {
        public VendorDetailRepository(SuplyManagementContext context) : base(context)
        {
        }
    }
}
