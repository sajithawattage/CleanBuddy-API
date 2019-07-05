using Cleaner.DataAccess.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cleaner.Model;
using Cleaner.DataAccess.SqlConstant;
using Dapper;
using System.Data;
using System.Data.Entity;

namespace Cleaner.DataAccess.Repositories
{
    public class EquipmentCategoryRepository<TEntity> : Repository<TEntity>, IEquipmentCategoryRepository<TEntity> where TEntity : class
    {
        private readonly CDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public EquipmentCategoryRepository(CDbContext context) : base(context)
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
