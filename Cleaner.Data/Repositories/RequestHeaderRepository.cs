using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleaner.Model;
using DataAccess.Infrastructure;
using Dapper;
using System.Data;
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

        public int Add(EquipmentCategory entity)
        {
            throw new NotImplementedException();
        }

        public void AddRequestHeader(RequestHeader requestHeader)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public EquipmentCategory Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EquipmentCategory> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EquipmentCategory>> GetAllActiveEquipmentCategoryList()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RequestHeader>> GetAllActiveRequestHeaderList()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RequestHeader>> GetAllRequestHeaderList()
        {
            throw new NotImplementedException();
        }

        public void RemoveRequestHeader(RequestHeader requestHeader)
        {
            throw new NotImplementedException();
        }

        public int Update(RequestHeader entity)
        {
            throw new NotImplementedException();
        }

        public int Update(EquipmentCategory entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRequestHeader(RequestHeader requestHeader)
        {
            throw new NotImplementedException();
        }

        RequestHeader IGenericRepository<RequestHeader>.Get(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<RequestHeader> IGenericRepository<RequestHeader>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
