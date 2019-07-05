using System.Collections.Generic;
using System.Data;
using System.Linq;
using Cleaner.DataAccess.SqlConstant;
using Cleaner.DataAccess.Infrastructure;
using Cleaner.Model;
using Dapper;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Cleaner.DataAccess.Repositories
{
    public class AddressRepository<TEntity> : Repository<TEntity>, IAddressRepository<TEntity> where TEntity : class
    {
        private readonly CDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public AddressRepository(CDbContext context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }       
    }
}
