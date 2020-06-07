using Cleaner.DataAccess;
using System.Collections.Generic;

namespace Cleaner.Business
{
    public interface IJobService
    {
        IEnumerable<Job> GetJobList();
        Job GetJobById(int id);
        bool SaveJob(Job job);
        bool UpdateJob(Job job);
        bool DeleteJob(int id);
    }
}
