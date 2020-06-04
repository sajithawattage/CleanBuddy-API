using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public interface ISiteSubContractorRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<SiteSubContractor>> GetAllActiveSiteSubContractorList();
    }
}
