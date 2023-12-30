using SuplyManagement.Contexts;
using SuplyManagement.Contracts;
using SuplyManagement.Models;

namespace SuplyManagement.Repositories
{
    public class ApprovalHistoryRepository : GeneralRepository<TbApprovalHistory>, IApprovalHistoryRepository
    {
        public ApprovalHistoryRepository(SuplyManagementContext context) : base(context)
        {
        }
    }
}
