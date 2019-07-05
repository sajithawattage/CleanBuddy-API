using Cleaner.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public interface ISiteRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<Site>> GetAllActiveSiteList();
        Task<IEnumerable<Site>> GetAllSiteList();
        void AddSite(Site site);
        void UpdateSite(Site site);
        void RemoveSite(Site site);
    }
}
