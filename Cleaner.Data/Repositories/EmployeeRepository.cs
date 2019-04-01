using System.Collections.Generic;
using System.Linq;
using Cleaner.Model;
using DataAccess.Infrastructure;
using Dapper;
using System.Data;
using Cleaner.DataAccess.SqlConstant;

namespace Cleaner.DataAccess.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        IConnectionFactory _connectionFactory;

        public EmployeeRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public int Add(Employee entity)
        {
            DynamicParameters param = new DynamicParameters();

            param.Add("@EmployeeName", entity.EmployeeName, DbType.String, ParameterDirection.Input);
            param.Add("@EmployeeContactNo", entity.EmployeeContactNo, DbType.Int32, ParameterDirection.Input);

            return SqlMapper.Execute(_connectionFactory.GetConnection, EmployeeSql.Insert, param: param,
                commandType: CommandType.StoredProcedure);
        }

        public int Delete(int id)
        {
            return SqlMapper.Execute(_connectionFactory.GetConnection, EmployeeSql.Delete,
                 new { id = id }, commandType: CommandType.Text);
        }

        public Employee Get(int id)
        {
            var list = SqlMapper.QueryFirst<Employee>(_connectionFactory.GetConnection, EmployeeSql.GetById,
                new { EmployeeID = id }, commandType: CommandType.Text);
            return list;
        }

        public IEnumerable<Employee> GetAll()
        {
            return SqlMapper.Query<Employee>(_connectionFactory.GetConnection, EmployeeSql.GetAll,
                commandType: CommandType.Text).ToList();
        }
        
        public int Update(Employee entity)
        {
            DynamicParameters param = new DynamicParameters();

            param.Add("@EmployeeID", entity.EmployeeID, DbType.Int32, ParameterDirection.Input);
            param.Add("@EmployeeName", entity.EmployeeName, DbType.String, ParameterDirection.Input);
            param.Add("@EmployeeContactNo", entity.EmployeeContactNo, DbType.Int32, ParameterDirection.Input);

            return SqlMapper.Execute(_connectionFactory.GetConnection, EmployeeSql.Update, param: param,
                commandType: CommandType.StoredProcedure);
        }
    }
}
