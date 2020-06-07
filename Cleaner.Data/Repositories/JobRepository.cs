using System.Data.Entity;

namespace Cleaner.DataAccess.Repositories
{
    public class JobRepository<TEntity> : Repository<TEntity>, IJobRepository<TEntity> where TEntity : class
    {
        private readonly KiaOraEntities _context;
        private readonly DbSet<TEntity> _dbSet;

        public JobRepository(KiaOraEntities context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        
    }
}
