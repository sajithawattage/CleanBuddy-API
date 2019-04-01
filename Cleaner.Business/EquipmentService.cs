using System.Collections.Generic;
using Cleaner.Model;
using Cleaner.DataAccess.Repositories;
using System.Threading.Tasks;

namespace Cleaner.Business
{
    public class EquipmentService : IEquipmentService
    {
        IEquipmentRepository _equipmentRepositary;

        public EquipmentService(IEquipmentRepository equipmentRepository)
        {
            _equipmentRepositary = equipmentRepository;
        }

        public Equipment GetEquipmentById(int id)
        {
            return _equipmentRepositary.Get(id);
        }

        public async Task<IEnumerable<Equipment>> GetEquipmentList()
        {
            return await _equipmentRepositary.GetAll();
        }

        public bool DeleteEquipment(int id)
        {
            return (_equipmentRepositary.Delete(id) > 0) ? true : false;
        }

        public bool SaveEquipment(Equipment equipment)
        {
            return (_equipmentRepositary.Add(equipment) > 0) ? true : false;
        }

        public bool UpdateEquipment(Equipment equipment)
        {
            return (_equipmentRepositary.Update(equipment) > 0) ? true : false;
        }
    }
}
