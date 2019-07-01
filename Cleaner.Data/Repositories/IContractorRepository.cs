using Cleaner.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public interface IContractorRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<Contractor>> GetAllActiveContractorList();
    }
}
