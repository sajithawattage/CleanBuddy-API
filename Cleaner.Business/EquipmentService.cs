using System.Collections.Generic;
using System.Threading.Tasks;
using Cleaner.DataAccess.UnitOfWork;
using Cleaner.DataAccess;

namespace Cleaner.Business
{
    public class EquipmentService : IEquipmentService
    {
        private IUnitOfWork _unitOfWork = null;

        public EquipmentService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public Equipment GetEquipmentById(int id)
        {
            return this._unitOfWork.EquipmentCategoryRepository<Equipment>().GetByID(id);
        }

        public  IEnumerable<Equipment> GetEquipmentList()
        {
            return this._unitOfWork.EquipmentCategoryRepository<Equipment>().GetAll();
        }

        public bool DeleteEquipment(int id)
        {
            this._unitOfWork.EquipmentCategoryRepository<Equipment>().Delete(id);
            return false;
        }

        public bool SaveEquipment(Equipment equipment)
        {
            this._unitOfWork.EquipmentCategoryRepository<Equipment>().Insert(equipment);
            return false;
        }

        public bool UpdateEquipment(Equipment equipment)
        {
            this._unitOfWork.EquipmentCategoryRepository<Equipment>().Update(equipment);
            return false;
        }
    }
}
