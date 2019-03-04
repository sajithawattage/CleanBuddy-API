using Cleaner.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public interface IUserLoginRepository : IGenericRepository<UserAccount>
    {
        Task<UserAccount> GetUser(string userName);
    }
}
