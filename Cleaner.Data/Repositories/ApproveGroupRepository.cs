using Cleaner.DataAccess.SqlConstant;
using Cleaner.Model;
using Cleaner.DataAccess.Infrastructure;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Cleaner.DataAccess.Repositories
{
    public class ApproveGroupRepository<TEntity> : Repository<TEntity>, IApproveGroupRepository<TEntity> where TEntity : class
    {
        private readonly CDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public ApproveGroupRepository(CDbContext context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
    }
}
