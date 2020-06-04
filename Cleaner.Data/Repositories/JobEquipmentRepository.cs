using System.Data.Entity;

namespace Cleaner.DataAccess.Repositories
{
    public class JobEquipmentRepository<TEntity> : Repository<TEntity>, IJobEquipmentRepository<TEntity> where TEntity : class
    {
        private readonly KiaOraEntities _context;
        private readonly DbSet<TEntity> _dbSet;

        public JobEquipmentRepository(KiaOraEntities context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
               
        
    }
}
