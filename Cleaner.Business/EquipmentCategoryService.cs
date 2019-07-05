using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleaner.Model;
using Cleaner.DataAccess.Repositories;
using Cleaner.DataAccess.UnitOfWork;

namespace Cleaner.Business
{
    public class EquipmentCategoryService : IEquipmentCategoryService
    {
        private IUnitOfWork _unitOfWork = null;

        public EquipmentCategoryService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public bool DeleteEquipmentCategory(int id)
        {
            this._unitOfWork.EquipmentCategoryRepository<EquipmentCategory>().Delete(id);
            return  false;
        }

        public EquipmentCategory GetEquipmentCategoryById(int id)
        {
            return this._unitOfWork.EquipmentCategoryRepository<EquipmentCategory>().GetByID(id);
        }

        public IEnumerable<EquipmentCategory> GetEquipmentCategoryList()
        {
            return this._unitOfWork.EquipmentCategoryRepository<EquipmentCategory>().GetAll();
        }

        public bool SaveEquipmentCategory(EquipmentCategory equipmentCategory)
        {
            this._unitOfWork.EquipmentCategoryRepository<EquipmentCategory>().Insert(equipmentCategory);
            return false;
        }

        public bool UpdateEquipmentCategory(EquipmentCategory equipmentCategory)
        {
            this._unitOfWork.EquipmentCategoryRepository<EquipmentCategory>().Update(equipmentCategory);
            return false;
        }
    }
}
