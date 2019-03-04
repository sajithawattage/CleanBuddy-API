using Cleaner.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public interface ISiteSubContractorRepository : IGenericRepository<SiteSubContractor>
    {
        Task<IEnumerable<SiteSubContractor>> GetAllActiveSiteSubContractorList();
    }
}
