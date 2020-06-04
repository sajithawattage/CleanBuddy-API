using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public interface IEquipmentCategoryRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<EquipmentCategory>> GetAllActiveEquipmentCategoryList();
    }
}
