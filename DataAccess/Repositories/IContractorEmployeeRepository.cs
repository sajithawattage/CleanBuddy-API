using Cleaner.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public interface IContractorEmployeeRepository : IGenericRepository<ContractorEmployee>
    {
        Task<IEnumerable<ContractorEmployee>> GetAllActiveContractorEmployeeList();
    }
}
