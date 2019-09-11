using Cleaner.DataAccess.UnitOfWork;
using Cleaner.Model;
using System.Collections.Generic;
using System.Linq;

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
            return _unitOfWork.EquipmentCategoryRepository<Equipment>().GetByID(id);
        }

        public IEnumerable<Equipment> GetEquipmentList()
        {
            return _unitOfWork.EquipmentCategoryRepository<DataAccess.Equipment>()
                .GetAll()
                .Select(x => new Equipment
                {
                    Id = x.ID,
                    Code = x.Code,
                    Brand = x.Brand,
                    Model = x.Model,
                    CategoryID = x.CategoryID,
                    PurchaseDate = x.PurchaseDate,
                    PurchasedFrom = x.PurchasedFrom,
                    WarrantyExpire = x.WarrantyExpire
                });
        }

        public bool DeleteEquipment(int id)
        {
            _unitOfWork.EquipmentCategoryRepository<Equipment>().Delete(id);
            return false;
        }

        public bool SaveEquipment(Equipment equipment)
        {
            _unitOfWork.EquipmentCategoryRepository<DataAccess.Equipment>().Insert(new DataAccess.Equipment
            {
                Brand = equipment.Brand,
                PurchasedFrom = equipment.PurchasedFrom,
                PurchaseDate = equipment.PurchaseDate,
                WarrantyExpire = equipment.WarrantyExpire,
                Model = equipment.Model,
                CategoryID = equipment.CategoryID,
                Code = equipment.Code
            });
            return false;
        }

        public bool UpdateEquipment(Equipment equipment)
        {
            _unitOfWork.EquipmentCategoryRepository<DataAccess.Equipment>().Update(new DataAccess.Equipment
            {
                Brand = equipment.Brand,
                PurchasedFrom = equipment.PurchasedFrom,
                PurchaseDate = equipment.PurchaseDate,
                WarrantyExpire = equipment.WarrantyExpire,
                Model = equipment.Model,
                CategoryID = equipment.CategoryID,
                Code = equipment.Code
            });
            return false;
        }

    }
}
