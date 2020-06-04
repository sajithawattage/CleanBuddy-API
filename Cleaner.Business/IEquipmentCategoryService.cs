using Cleaner.DataAccess;
using System.Collections.Generic;

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
