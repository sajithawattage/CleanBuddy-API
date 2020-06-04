using Cleaner.DataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.Business
{
    public interface IJobService
    {
        Task<IEnumerable<Job>> GetJobList();
        Job GetJobById(int id);
        bool SaveJob(Job job);
        bool UpdateJob(Job job);
        bool DeleteJob(int id);
    }
}
