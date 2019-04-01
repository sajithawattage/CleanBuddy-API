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
    public class JobEquipmentRepository : IJobEquipmentRepository
    {
        IConnectionFactory _connectionFactory;

        public JobEquipmentRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public int Add(JobEquipment entity)
        {
            DynamicParameters param = new DynamicParameters();

            param.Add("@ID", entity.ID, DbType.Int32, ParameterDirection.Input);
            param.Add("@JobID", entity.JobID, DbType.Int32, ParameterDirection.Input);
            param.Add("@EquipmentID", entity.EquipmentID, DbType.Int32, ParameterDirection.Input);
            
            return SqlMapper.Execute(_connectionFactory.GetConnection, JobEquipmentSql.Insert, param: param,
                commandType: CommandType.StoredProcedure);
        }
        
        public int Delete(int id)
        {
            return SqlMapper.Execute(_connectionFactory.GetConnection, JobEquipmentSql.Delete,
                 new { id = id }, commandType: CommandType.Text);
        }

        public JobEquipment Get(int id)
        {
            var address = SqlMapper.QueryFirst<JobEquipment>(_connectionFactory.GetConnection, JobEquipmentSql.GetById,
                new { ID = id }, commandType: CommandType.Text);
            return address;
        }

        public IEnumerable<JobEquipment> GetAll()
        {
            return SqlMapper.Query<JobEquipment>(_connectionFactory.GetConnection, JobEquipmentSql.GetAll,
               commandType: CommandType.Text).ToList();
        }

        
        public int Update(JobEquipment entity)
        {
            DynamicParameters param = new DynamicParameters();

            param.Add("@ID", entity.ID, DbType.Int32, ParameterDirection.Input);
            param.Add("@JobID", entity.JobID, DbType.Int32, ParameterDirection.Input);
            param.Add("@EquipmentID", entity.EquipmentID, DbType.Int32, ParameterDirection.Input);

            return SqlMapper.Execute(_connectionFactory.GetConnection, JobEquipmentSql.Update, param: param,
                commandType: CommandType.StoredProcedure);
        }
        
    }
}
