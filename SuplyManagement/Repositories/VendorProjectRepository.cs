using SuplyManagement.Contexts;
using SuplyManagement.Models;

namespace SuplyManagement.Repositories
{
    public class VendorProjectRepository : GeneralRepository<TbVendorProject>
    {
        public VendorProjectRepository(SuplyManagementContext context) : base(context)
        {
        }
    }
}
