using DataAccess.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleaner.Model;
using Cleaner.DataAccess.SqlConstant;
using Dapper;
using System.Data;

namespace Cleaner.DataAccess.Repositories
{
    public class EquipmentCategoryRepository :IEquipmentCategoryRepository
    {
        IConnectionFactory _connectionFactory;

        public EquipmentCategoryRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public int Add(EquipmentCategory entity)
        {
            DynamicParameters param = new DynamicParameters();

            param.Add("@Code", entity.ID, DbType.String, ParameterDirection.Input);
            param.Add("@Brand", entity.Name, DbType.String, ParameterDirection.Input);
            
            return SqlMapper.Execute(_connectionFactory.GetConnection, EquipmentCategorySql.Insert, param: param,
                commandType: CommandType.StoredProcedure);
        }

        public int Delete(int id)
        {
            return SqlMapper.Execute(_connectionFactory.GetConnection, EquipmentCategorySql.Delete,
                 new { id = id }, commandType: CommandType.Text);
        }

        public EquipmentCategory Get(int id)
        {
            var list = SqlMapper.QueryFirst<EquipmentCategory>(_connectionFactory.GetConnection, EquipmentCategorySql.GetById,
                new { id = id }, commandType: CommandType.Text);
            return list;
        }

        public IEnumerable<EquipmentCategory> GetAll()
        {
            return SqlMapper.Query<EquipmentCategory>(_connectionFactory.GetConnection, EquipmentCategorySql.GetAll,
                commandType: CommandType.Text).ToList();
        }

        public Task<IEnumerable<EquipmentCategory>> GetAllActiveEquipmentCategoryList()
        {
            throw new NotImplementedException();
        }

        public int Update(EquipmentCategory entity)
        {
            DynamicParameters param = new DynamicParameters();

            param.Add("@ID", entity.ID, DbType.Int16, ParameterDirection.Input);
            param.Add("@Code", entity.Name, DbType.String, ParameterDirection.Input);
            
            return SqlMapper.Execute(_connectionFactory.GetConnection, EquipmentCategorySql.Update, param: param,
                commandType: CommandType.StoredProcedure);
        }
    }
}
