using System.Collections.Generic;
using System.Linq;
using Cleaner.Model;
using Cleaner.DataAccess.Infrastructure;
using Dapper;
using System.Data;
using Cleaner.DataAccess.SqlConstant;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public class ApproveGroupUserRepository : IApproveGroupUserRepository
    {
        IConnectionFactory _connectionFactory;

        public ApproveGroupUserRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public int Add(ApproveGroupUser entity)
        {
            DynamicParameters param = new DynamicParameters();

            param.Add("@GroupID", entity.GroupID, DbType.Int32, ParameterDirection.Input);
            param.Add("@UserID", entity.UserID, DbType.Int32, ParameterDirection.Input);

            return SqlMapper.Execute(_connectionFactory.GetConnection, ApproveGroupUserSql.Insert, param: param,
                commandType: CommandType.StoredProcedure);
        }

        public int Delete(int id)
        {
            return SqlMapper.Execute(_connectionFactory.GetConnection, ApproveGroupUserSql.Delete,
                 new { id = id }, commandType: CommandType.Text);
        }

        public ApproveGroupUser Get(int id)
        {
            var users = SqlMapper.QueryFirst<ApproveGroupUser>(_connectionFactory.GetConnection, ApproveGroupUserSql.GetById,
                new { AddressID = id }, commandType: CommandType.Text);
            return users;
        }

        public Task<IEnumerable<ApproveGroupUser>> GetAll()
        {
            return SqlMapper.QueryAsync<ApproveGroupUser>(_connectionFactory.GetConnection, ApproveGroupUserSql.GetAll,
              commandType: CommandType.Text);
        }
        
        public int Update(ApproveGroupUser entity)
        {
            DynamicParameters param = new DynamicParameters();

            param.Add("@ID", entity.GroupID, DbType.Int32, ParameterDirection.Input);
            param.Add("@GroupID", entity.GroupID, DbType.Int32, ParameterDirection.Input);
            param.Add("@UserID", entity.UserID, DbType.Int32, ParameterDirection.Input);

            return SqlMapper.Execute(_connectionFactory.GetConnection, ApproveGroupUserSql.Update, param: param,
                commandType: CommandType.StoredProcedure);
        }
    }
}
