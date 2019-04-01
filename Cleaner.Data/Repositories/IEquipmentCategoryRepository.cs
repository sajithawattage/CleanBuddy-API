using Cleaner.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public interface IEquipmentCategoryRepository : IGenericRepository<EquipmentCategory>
    {
        Task<IEnumerable<EquipmentCategory>> GetAllActiveEquipmentCategoryList();
    }
}
