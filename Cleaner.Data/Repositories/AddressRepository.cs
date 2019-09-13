using Cleaner.DataAccess.Infrastructure;
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
