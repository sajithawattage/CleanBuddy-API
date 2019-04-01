using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleaner.Model;
using Cleaner.DataAccess.Repositories;

namespace Cleaner.Business
{
    public class EquipmentCategoryService : IEquipmentCategoryService
    {
        IEquipmentCategoryRepository _equipmentCategoryRepositary;

        public EquipmentCategoryService(IEquipmentCategoryRepository equipmentCategoryRepository)
        {
            _equipmentCategoryRepositary = equipmentCategoryRepository;
        }

        public bool DeleteEquipmentCategory(int id)
        {
            return (_equipmentCategoryRepositary.Delete(id) > 0) ? true : false;
        }

        public EquipmentCategory GetEquipmentCategoryById(int id)
        {
            return _equipmentCategoryRepositary.Get(id);
        }

        public Task<IEnumerable<EquipmentCategory>> GetEquipmentCategoryList()
        {
            return _equipmentCategoryRepositary.GetAll();
        }

        public bool SaveEquipmentCategory(EquipmentCategory equipmentCategory)
        {
            return (_equipmentCategoryRepositary.Add(equipmentCategory) > 0) ? true : false;
        }

        public bool UpdateEquipmentCategory(EquipmentCategory equipmentCategory)
        {
            return (_equipmentCategoryRepositary.Add(equipmentCategory) > 0) ? true : false;
        }
    }
}
