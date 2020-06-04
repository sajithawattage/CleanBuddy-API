using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Cleaner.DataAccess.Repositories
{
    public class EquipmentCategoryRepository<TEntity> : Repository<TEntity>, IEquipmentCategoryRepository<TEntity> where TEntity : class
    {
        private readonly KiaOraEntities _context;
        private readonly DbSet<TEntity> _dbSet;

        public EquipmentCategoryRepository(KiaOraEntities context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public Task<IEnumerable<EquipmentCategory>> GetAllActiveEquipmentCategoryList()
        {
            throw new NotImplementedException();
        }
    }
}
