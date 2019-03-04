using Cleaner.DataAccess.SqlConstant;
using Cleaner.Model;
using Dapper;
using DataAccess.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public class ApproveGroupRepository : IGenericRepository<ApproveGroup>, IApproveGroupRepository
    {
        IConnectionFactory _connectionFactory;

        public ApproveGroupRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public int Add(ApproveGroup entity)
        {
            return -1;
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ApproveGroup Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApproveGroup> GetAll()
        {
            return SqlMapper.Query<ApproveGroup>(_connectionFactory.GetConnection, ApproveGroupSql.GetAll,
               commandType: CommandType.Text).ToList();
        }

        public int Update(ApproveGroup entity)
        {
            throw new NotImplementedException();
        }
    }
}
