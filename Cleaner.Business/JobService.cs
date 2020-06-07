using System.Collections.Generic;
using System.Threading.Tasks;
using Cleaner.DataAccess.UnitOfWork;
using Cleaner.DataAccess;

namespace Cleaner.Business
{
    public class JobService : IJobService
    {
        private IUnitOfWork _unitOfWork = null;

        public JobService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public bool DeleteJob(int id)
        {
            this._unitOfWork.JobRepository<Job>().Delete(id);
            return false;
        }

        public Job GetJobById(int id)
        {
            return this._unitOfWork.JobRepository<Job>().GetByID(id);
        }

        public IEnumerable<Job> GetJobList()
        {
            return _unitOfWork.JobRepository<Job>().GetAll();
        }

        public bool SaveJob(Job job)
        {
            this._unitOfWork.JobRepository<Job>().Insert(job);
            return  false;
        }

        public bool UpdateJob(Job job)
        {
            this._unitOfWork.JobRepository<Job>().Update(job);
            return  false;
        }
    }
}
