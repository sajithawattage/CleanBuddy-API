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

namespace Cleaner.DataAccess.Repositories
{
    public class UserLoginRepository : IUserLoginRepository
    {
        IConnectionFactory _connectionFactory;

        public UserLoginRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public int Add(UserAccount entity)
        {
            DynamicParameters param = new DynamicParameters();
            
            param.Add("@UserName", entity.UserID, DbType.String, ParameterDirection.Input);
            param.Add("@PasswordHash", entity.PasswordHash, DbType.String, ParameterDirection.Input);
            param.Add("@UserRoleID", entity.UserRoleID, DbType.Int16, ParameterDirection.Input);
            param.Add("@EmployeeID", entity.EmployeeID, DbType.Int16, ParameterDirection.Input);
            
            return SqlMapper.Execute(_connectionFactory.GetConnection, UserSql.Insert, param: param,
                commandType: CommandType.StoredProcedure);
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public UserAccount Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserAccount>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UserAccount> GetUser(string userName)
        {
            DynamicParameters param = new DynamicParameters();

            param.Add("@UserName", userName, DbType.String, ParameterDirection.Input);

            var user = SqlMapper.QueryFirst<UserAccount>(_connectionFactory.GetConnection, UserSql.GetByUserName,
               param, commandType: CommandType.StoredProcedure);

            return Task.FromResult(user);
        }

        public int Update(UserAccount entity)
        {
            throw new NotImplementedException();
        }
    }
}
