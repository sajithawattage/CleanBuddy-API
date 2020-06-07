using Cleaner.DataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.Business
{
    public interface IJobEquipmentService
    {
        IEnumerable<JobEquipment> GetJobEquipmentList();
        JobEquipment GetJobEquipmentById(int id);
        bool SaveJobEquipment(JobEquipment jobEquipment);
        bool UpdateJobEquipment(JobEquipment jobEquipment);
        bool DeleteJobEquipment(int id);
    }
}
