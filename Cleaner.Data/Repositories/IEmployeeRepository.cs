using Cleaner.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public interface IEmployeeRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {

    }
}
