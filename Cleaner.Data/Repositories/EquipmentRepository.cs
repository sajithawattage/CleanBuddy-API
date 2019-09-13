using Cleaner.DataAccess.SqlConstant;
using Cleaner.Model;

using Cleaner.DataAccess.Infrastructure;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Cleaner.DataAccess.Repositories
{
    public class EquipmentRepository<TEntity> : Repository<TEntity>, IEquipmentRepository<TEntity> where TEntity : class
    {
        private readonly CDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public EquipmentRepository(CDbContext context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

       
        
    }
}
