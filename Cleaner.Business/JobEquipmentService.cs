using System.Collections.Generic;
using System.Threading.Tasks;
using Cleaner.DataAccess;
using Cleaner.DataAccess.UnitOfWork;

namespace Cleaner.Business
{
    public class JobEquipmentService : IJobEquipmentService
    {
        private IUnitOfWork _unitOfWork = null;

        public JobEquipmentService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public bool DeleteJobEquipment(int id)
        {
            this._unitOfWork.JobRepository<JobEquipment>().Delete(id);
            return false;
        }

        public JobEquipment GetJobEquipmentById(int id)
        {
            return this._unitOfWork.JobRepository<JobEquipment>().GetByID(id);
        }

        public Task<IEnumerable<JobEquipment>> GetJobEquipmentList()
        {
            return null;
        }

        public bool SaveJobEquipment(JobEquipment jobEquipment)
        {
            this._unitOfWork.JobRepository<JobEquipment>().Insert(jobEquipment);
            return  false;
        }

        public bool UpdateJobEquipment(JobEquipment jobEquipment)
        {
            this._unitOfWork.JobRepository<JobEquipment>().Update(jobEquipment);
            return false;
        }
    }
}
