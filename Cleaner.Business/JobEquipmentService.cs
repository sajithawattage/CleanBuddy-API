using System;
using System.Collections.Generic;
using Cleaner.Model;
using Cleaner.DataAccess.Repositories;

namespace Cleaner.Business
{
    public class JobEquipmentService : IJobEquipmentService
    {
        IJobEquipmentRepository _jobEquipmentRepo;

        public JobEquipmentService(IJobEquipmentRepository jobEquipmentRepo)
        {
            _jobEquipmentRepo  = jobEquipmentRepo;
        }

        public bool DeleteJobEquipment(int id)
        {
            return (_jobEquipmentRepo.Delete(id) > 0) ? true : false;
        }

        public JobEquipment GetJobEquipmentById(int id)
        {
            return _jobEquipmentRepo.Get(id);
        }

        public IEnumerable<JobEquipment> GetJobEquipmentList()
        {
            return _jobEquipmentRepo.GetAll();
        }

        public bool SaveJobEquipment(JobEquipment jobEquipment)
        {
            return (_jobEquipmentRepo.Add(jobEquipment) > 0) ? true : false;
        }

        public bool UpdateJobEquipment(JobEquipment jobEquipment)
        {
            return (_jobEquipmentRepo.Update(jobEquipment) > 0) ? true : false;
        }
    }
}
