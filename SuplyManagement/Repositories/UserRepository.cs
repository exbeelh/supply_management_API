using SuplyManagement.Contexts;
using SuplyManagement.Contracts;
using SuplyManagement.DTOs.UserDto;
using SuplyManagement.Models;
using SuplyManagement.Utilities.Handlers;

namespace SuplyManagement.Repositories
{
    public class UserRepository : GeneralRepository<TbUser>, IUserRepository
    {

        public UserRepository(SuplyManagementContext context) : base(context)
        {

        }
    }
}
