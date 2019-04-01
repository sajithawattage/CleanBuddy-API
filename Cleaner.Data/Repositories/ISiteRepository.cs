using Cleaner.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public interface ISiteRepository : IGenericRepository<Site>
    {
        Task<IEnumerable<Site>> GetAllActiveSiteList();
        Task<IEnumerable<Site>> GetAllSiteList();
        void AddSite(Site site);
        void UpdateSite(Site site);
        void RemoveSite(Site site);
    }
}
