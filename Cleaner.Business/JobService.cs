using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleaner.Model;
using Cleaner.DataAccess.Repositories;

namespace Cleaner.Business
{
    public class JobService : IJobService
    {
        IJobRepository _jobRepo;

        public JobService(IJobRepository jobRepo)
        {
            _jobRepo = jobRepo;
        }

        public bool DeleteJob(int id)
        {
            return (_jobRepo.Delete(id) > 0) ? true : false;
        }

        public Job GetJobById(int id)
        {
            return _jobRepo.Get(id);
        }

        public IEnumerable<Job> GetJobList()
        {
            return _jobRepo.GetAll();
        }

        public bool SaveJob(Job job)
        {
            return (_jobRepo.Add(job) > 0) ? true : false;
        }

        public bool UpdateJob(Job job)
        {
            return (_jobRepo.Update(job) > 0) ? true : false;
        }
    }
}
