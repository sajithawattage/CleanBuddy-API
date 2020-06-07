using Cleaner.DataAccess.Infrastructure;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace Cleaner.DataAccess.Repositories
{
    public class UserLoginRepository<TEntity> : Repository<TEntity>, IUserLoginRepository<TEntity> where TEntity : class
    {
        private readonly KiaOraEntities _context;
        private readonly DbSet<TEntity> _dbSet;

        public UserLoginRepository(KiaOraEntities context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public UserAccount GetUser(string userName)
        {
            var query = _context.UserAccounts
                .Where(x => x.UserName == userName).ToList();

            if (query.Any())
            {
                return query.FirstOrDefault();
            }

            return null;
        }
    }
}
