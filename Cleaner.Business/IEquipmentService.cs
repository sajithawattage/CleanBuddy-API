using Cleaner.DataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.Business
{
    public interface IEquipmentService
    {
        IEnumerable<Equipment> GetEquipmentList();
        Equipment GetEquipmentById(int id);
        bool SaveEquipment(Equipment equipment);
        bool UpdateEquipment(Equipment equipment);
        bool DeleteEquipment(int id);
    }
}
