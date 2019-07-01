using Cleaner.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public interface IUserLoginRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        Task<UserAccount> GetUser(string userName);
    }
}
