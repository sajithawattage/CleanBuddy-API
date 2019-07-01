using System.Collections.Generic;
using Cleaner.Model;
using Cleaner.DataAccess.Repositories;
using System.Threading.Tasks;
using Cleaner.DataAccess.UnitOfWork;

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

        public async IEnumerable<Equipment> GetEquipmentList()
        {
            return await this._unitOfWork.EquipmentCategoryRepository<EquipmentCategory>().Delete(id);
        }

        public bool DeleteEquipment(int id)
        {
            this._unitOfWork.EquipmentCategoryRepository<EquipmentCategory>().Delete(id);
            return false;
        }

        public bool SaveEquipment(Equipment equipment)
        {
            this._unitOfWork.EquipmentCategoryRepository<EquipmentCategory>().Delete(id);
            return false;
        }

        public bool UpdateEquipment(Equipment equipment)
        {
            this._unitOfWork.EquipmentCategoryRepository<EquipmentCategory>().Delete(id);
            return false;
        }
    }
}
