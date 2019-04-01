using Cleaner.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.Business
{
    public interface IEquipmentService
    {
        Task<IEnumerable<Equipment>> GetEquipmentList();
        Equipment GetEquipmentById(int id);
        bool SaveEquipment(Equipment equipment);
        bool UpdateEquipment(Equipment equipment);
        bool DeleteEquipment(int id);
    }
}
