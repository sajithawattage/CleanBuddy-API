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
        private readonly CDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public UserLoginRepository(CDbContext context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public Task<UserAccount> GetUser(string userName)
        {
            throw new NotImplementedException();
        }
    }
}
