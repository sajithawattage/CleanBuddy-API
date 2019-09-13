using System.Collections.Generic;
using System.Linq;
using Cleaner.Model;
using Cleaner.DataAccess.Infrastructure;

using Cleaner.DataAccess.SqlConstant;
using System.Data;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Cleaner.DataAccess.Repositories
{
    public class JobRepository<TEntity> : Repository<TEntity>, IJobRepository<TEntity> where TEntity : class
    {
        private readonly CDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public JobRepository(CDbContext context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        
    }
}
