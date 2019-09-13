using System.Collections.Generic;
using System.Linq;
using Cleaner.Model;
using Cleaner.DataAccess.Infrastructure;

using System.Data;
using Cleaner.DataAccess.SqlConstant;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Cleaner.DataAccess.Repositories
{
    public class EmployeeRepository<TEntity> : Repository<TEntity>, IEmployeeRepository<TEntity> where TEntity : class
    {
        private readonly CDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public EmployeeRepository(CDbContext context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        
    }
}
