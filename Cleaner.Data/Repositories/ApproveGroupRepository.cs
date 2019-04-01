using Cleaner.DataAccess.SqlConstant;
using Cleaner.Model;
using Cleaner.DataAccess.Infrastructure;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public class ApproveGroupRepository : IApproveGroupRepository
    {
        IConnectionFactory _connectionFactory;

        public ApproveGroupRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public int Add(ApproveGroup entity)
        {
            DynamicParameters param = new DynamicParameters();
            
            param.Add("@GroupName", entity.GroupName, DbType.String, ParameterDirection.Input);
            param.Add("@Description", entity.Description, DbType.String, ParameterDirection.Input);
            
            return SqlMapper.Execute(_connectionFactory.GetConnection, ApproveGroupSql.Insert, param: param,
                commandType: CommandType.StoredProcedure);
        }

        public int Delete(int id)
        {
            return SqlMapper.Execute(_connectionFactory.GetConnection, ApproveGroupSql.Delete,
                 new { id = id }, commandType: CommandType.Text);
        }

        public ApproveGroup Get(int id)
        {
            var address = SqlMapper.QueryFirst<ApproveGroup>(_connectionFactory.GetConnection, ApproveGroupSql.GetById,
                new { AddressID = id }, commandType: CommandType.Text);
            return address;
        }

        public Task<IEnumerable<ApproveGroup>> GetAll()
        {
            return SqlMapper.QueryAsync<ApproveGroup>(_connectionFactory.GetConnection, ApproveGroupSql.GetAll,
               commandType: CommandType.Text);
        }

        public int Update(ApproveGroup entity)
        {
            DynamicParameters param = new DynamicParameters();

            param.Add("@GroupID", entity.GroupID, DbType.Int32, ParameterDirection.Input);
            param.Add("@GroupName", entity.GroupName, DbType.String, ParameterDirection.Input);
            param.Add("@Description", entity.Description, DbType.String, ParameterDirection.Input);

            return SqlMapper.Execute(_connectionFactory.GetConnection, ApproveGroupSql.Update, param: param,
                commandType: CommandType.StoredProcedure);
        }
    }
}
