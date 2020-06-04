using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public interface IWorkTypeRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<WorkType>> GetAllWorkTypeList();
    }
}
