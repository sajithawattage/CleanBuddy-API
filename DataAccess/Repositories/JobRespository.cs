using System.Collections.Generic;
using System.Linq;
using Cleaner.Model;
using DataAccess.Infrastructure;
using Dapper;
using Cleaner.DataAccess.SqlConstant;
using System.Data;

namespace Cleaner.DataAccess.Repositories
{
    public class JobRespository : IJobRepository
    {
        IConnectionFactory _connectionFactory;

        public JobRespository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public int Add(Job entity)
        {
            DynamicParameters param = new DynamicParameters();

            param.Add("@Code", entity.ID, DbType.Int32, ParameterDirection.Input);
            param.Add("@SiteID", entity.SiteID, DbType.String, ParameterDirection.Input);
            param.Add("@JobStartDate", entity.JobStartDate, DbType.Date, ParameterDirection.Input);
            
            return SqlMapper.Execute(_connectionFactory.GetConnection, EquipmentSql.Insert, param: param,
                commandType: CommandType.StoredProcedure);
        }
        
        public int Delete(int id)
        {
            return SqlMapper.Execute(_connectionFactory.GetConnection, JobSql.Delete,
                 new { ID = id }, commandType: CommandType.Text);
        }

        public Job Get(int id)
        {
            var list = SqlMapper.QueryFirst<Job>(_connectionFactory.GetConnection, JobSql.GetById,
                new { ID = id }, commandType: CommandType.Text);
            return list;
        }

        public IEnumerable<Job> GetAll()
        {
            return SqlMapper.Query<Job>(_connectionFactory.GetConnection, JobSql.GetAll,
                commandType: CommandType.Text).ToList();
        }
       
        public int Update(Job entity)
        {
            DynamicParameters param = new DynamicParameters();

            param.Add("@Code", entity.ID, DbType.Int32, ParameterDirection.Input);
            param.Add("@SiteID", entity.SiteID, DbType.String, ParameterDirection.Input);
            param.Add("@JobStartDate", entity.JobStartDate, DbType.Date, ParameterDirection.Input);

            return SqlMapper.Execute(_connectionFactory.GetConnection, EquipmentSql.Update, param: param,
                commandType: CommandType.StoredProcedure);
        }
        
    }
}
