using Cleaner.DataAccess.SqlConstant;
using Cleaner.Model;
using Dapper;
using Cleaner.DataAccess.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

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

        public Task<UserAccount> GetUser(string userName)
        {
            IQueryable<UserAccount> x = from user in _context.UserLogins
                    where user.UserName == userName
                    select new UserAccount
                    {
                        PasswordHash = user.PasswordHash,
                        UserName = user.UserName,
                        EmployeeID = user.EmployeeID.Value,
                        UserRoleID = user.UserRoleID.Value
                    };

            return x.FirstOrDefaultAsync();
        }
    }
}
