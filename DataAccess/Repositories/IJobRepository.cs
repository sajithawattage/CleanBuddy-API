using Cleaner.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public interface IJobRepository : IGenericRepository<Job>
    {
        Task<IEnumerable<Job>> GetAllActiveJobList();
        Task<IEnumerable<Job>> GetAllJobList();
        void AddJob(Job job);
        void UpdateJob(Job job);
        void RemoveJob(Job job);
    }
}
