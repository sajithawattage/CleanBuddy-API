using System.Data.Entity;

namespace Cleaner.DataAccess.Repositories
{
    public class EmployeeRepository<TEntity> : Repository<TEntity>, IEmployeeRepository<TEntity> where TEntity : class
    {
        private readonly KiaOraEntities _context;
        private readonly DbSet<TEntity> _dbSet;

        public EmployeeRepository(KiaOraEntities context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
    }
}
