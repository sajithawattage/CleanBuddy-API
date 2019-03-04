using Cleaner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
