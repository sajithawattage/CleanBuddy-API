using Cleaner.DataAccess.Infrastructure;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace Cleaner.DataAccess.Repositories
{
    public class UserLoginRepository<TEntity> : Repository<TEntity>, IUserLoginRepository<TEntity> where TEntity : class
    {
        private readonly CDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public UserLoginRepository(CDbContext context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public Model.UserAccount GetUser(string userName)
        {
            var query = from x in _context.UserAccount
                        where x.UserName == userName
                        select new Model.UserAccount
                        {
                            Id = x.Id,
                            UserName = x.UserName,
                            UserRoleID = x.UserRoleID,
                            EmployeeID = x.EmployeeID,
                            PasswordHash = x.PasswordHash,
                            CreatedDate = x.CreatedDate,
                            UpdateDate = x.UpdateDate
                        };

            if (query.Any())
            {
                return query.FirstOrDefault();
            }
            return null;
        }
    }
}
