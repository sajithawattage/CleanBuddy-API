using Cleaner.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public interface IJobEquipmentRepository : IGenericRepository<JobEquipment>
    {
        Task<IEnumerable<JobEquipment>> GetAllActiveJobEquipmentList();
        Task<IEnumerable<JobEquipment>> GetAllJobEquipmentList();
        void AddJobEquipment(JobEquipment jobEquipment);
        void UpdateJobEquipment(JobEquipment jobEquipment);
        void RemoveJobEquipment(JobEquipment jobEquipment);
    }
}
