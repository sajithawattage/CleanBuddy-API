using Cleaner.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public interface IWorkTypeRepository : IGenericRepository<WorkType>
    {
        Task<IEnumerable<WorkType>> GetAllWorkTypeList();
    }
}
