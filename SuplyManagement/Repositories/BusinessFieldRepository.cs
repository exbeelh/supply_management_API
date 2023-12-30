using SuplyManagement.Contexts;

namespace SuplyManagement.Repositories
{
    public class BusinessFieldRepository : GeneralRepository<BusinessFieldRepository>
    {
        public BusinessFieldRepository(SuplyManagementContext context) : base(context)
        {
        }
    }
}
