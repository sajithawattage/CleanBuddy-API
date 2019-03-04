using Cleaner.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public interface ISubContractorRepository : IGenericRepository<SubContractor>
    {
        Task<IEnumerable<SubContractor>> GetAllActiveSubContractorList();
    }
}
