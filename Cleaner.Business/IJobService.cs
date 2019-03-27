using Cleaner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
