using Cleaner.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public interface IContractorRepository : IGenericRepository<Contractor>
    {
        Task<IEnumerable<Contractor>> GetAllActiveContractorList();
    }
}
