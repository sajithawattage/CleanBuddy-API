using Cleaner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Business
{
    public interface IEquipmentCategoryService
    {
        IEnumerable<EquipmentCategory> GetEquipmentCategoryList();
        EquipmentCategory GetEquipmentCategoryById(int id);
        bool SaveEquipmentCategory(EquipmentCategory equipmentCategory);
        bool UpdateEquipmentCategory(EquipmentCategory equipmentCategory);
        bool DeleteEquipmentCategory(int id);
    }
}
