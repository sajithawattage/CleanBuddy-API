using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        int Add(TEntity entity);
        int Delete(int id);
        int Update(TEntity entity);
    }
}
