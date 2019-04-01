using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Cleaner.Model;
using Cleaner.DataAccess.Infrastructure;
using Dapper;
using Cleaner.DataAccess.SqlConstant;

namespace Cleaner.DataAccess.Repositories
{
    public class RequestHeaderRepository : IRequestHeaderRepository
    {
        IConnectionFactory _connectionFactory;

        public RequestHeaderRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public int Add(RequestHeader entity)
        {
            DynamicParameters param = new DynamicParameters();

            param.Add("@RequestID", entity.RequestID, DbType.Int32, ParameterDirection.Input);
            param.Add("@GroupID", entity.GroupID, DbType.Int32, ParameterDirection.Input);
            param.Add("@EmployeeID", entity.EmployeeID, DbType.Date, ParameterDirection.Input);
            param.Add("@JobID", entity.JobID, DbType.Int32, ParameterDirection.Input);
            param.Add("@RequestDateTime", entity.RequestDateTime, DbType.String, ParameterDirection.Input);
            param.Add("@ApproveGroupID", entity.ApproveGroupID, DbType.Date, ParameterDirection.Input);
            param.Add("@CreatedDate", entity.CreatedDate, DbType.Int32, ParameterDirection.Input);
            
            return SqlMapper.Execute(_connectionFactory.GetConnection, RequestHeaderSql.Insert, param: param,
                commandType: CommandType.StoredProcedure);
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public RequestHeader Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RequestHeader>> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(RequestHeader entity)
        {
            throw new NotImplementedException();
        }
    }
}
