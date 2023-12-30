using SuplyManagement.Contexts;
using SuplyManagement.Models;

namespace SuplyManagement.Repositories
{
    public class ApprovalHistoryRepository : GeneralRepository<TbApprovalHistory>
    {
        public ApprovalHistoryRepository(SuplyManagementContext context) : base(context)
        {
        }
    }
}
