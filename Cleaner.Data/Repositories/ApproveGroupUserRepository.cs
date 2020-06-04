using System.Data.Entity;

namespace Cleaner.DataAccess.Repositories
{
    public class ApproveGroupUserRepository<TEntity> : Repository<TEntity>, IApproveGroupUserRepository<TEntity> where TEntity : class
    {
        private readonly KiaOraEntities _context;
        private readonly DbSet<TEntity> _dbSet;

        public ApproveGroupUserRepository(KiaOraEntities context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        
    }
}
