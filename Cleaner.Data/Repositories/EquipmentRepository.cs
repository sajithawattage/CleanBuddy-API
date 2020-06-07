using System.Data.Entity;

namespace Cleaner.DataAccess.Repositories
{
    public class EquipmentRepository<TEntity> : Repository<TEntity>, IEquipmentRepository<TEntity> where TEntity : class
    {
        private readonly KiaOraEntities _context;
        private readonly DbSet<TEntity> _dbSet;

        public EquipmentRepository(KiaOraEntities context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        
    }
}
