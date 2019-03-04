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
    public class EquipmentRepository : IGenericRepository<Equipment>, IEquipmentRepository
    {
        IConnectionFactory _connectionFactory;

        public EquipmentRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        
        public IEnumerable<Equipment> GetAll()
        {
            return SqlMapper.Query<Equipment>(_connectionFactory.GetConnection, EquipmentSql.GetAll, 
                commandType: CommandType.Text).ToList();
        }

        public Equipment Get(int id)
        {
            var list = SqlMapper.QueryFirst<Equipment>(_connectionFactory.GetConnection, EquipmentSql.GetById,
                new { id = id }, commandType: CommandType.Text);
            return list;
        }

        public int Delete(int id)
        {
            return SqlMapper.Execute(_connectionFactory.GetConnection, EquipmentSql.Delete,
                 new { id = id }, commandType: CommandType.Text);
        }

        public int Add(Equipment entity)
        {
            DynamicParameters param = new DynamicParameters();

            param.Add("@Code", entity.Code, DbType.String, ParameterDirection.Input);
            param.Add("@Brand", entity.Brand, DbType.String, ParameterDirection.Input);
            param.Add("@Model", entity.Model, DbType.String, ParameterDirection.Input);
            param.Add("@CategoryID", entity.CategoryID, DbType.Int16, ParameterDirection.Input);
            param.Add("@PurchasedFrom", entity.PurchasedFrom, DbType.String, ParameterDirection.Input);
            param.Add("@PurchaseDate", entity.PurchaseDate, DbType.Date, ParameterDirection.Input);
            param.Add("@WarrantyExpire", entity.WarrantyExpire, DbType.Date, ParameterDirection.Input);

            return SqlMapper.Execute(_connectionFactory.GetConnection, EquipmentSql.Insert, param: param,
                commandType: CommandType.StoredProcedure);
        }
        
        public int Update(Equipment entity)
        {
            DynamicParameters param = new DynamicParameters();

            param.Add("@ID", entity.ID, DbType.Int16, ParameterDirection.Input);
            param.Add("@Code", entity.Code, DbType.String, ParameterDirection.Input);
            param.Add("@Brand", entity.Brand, DbType.String, ParameterDirection.Input);
            param.Add("@Model", entity.Model, DbType.String, ParameterDirection.Input);
            param.Add("@CategoryID", entity.CategoryID, DbType.Int16, ParameterDirection.Input);
            param.Add("@PurchasedFrom", entity.PurchasedFrom, DbType.String, ParameterDirection.Input);
            param.Add("@PurchaseDate", entity.PurchaseDate, DbType.Date, ParameterDirection.Input);
            param.Add("@WarrantyExpire", entity.WarrantyExpire, DbType.Date, ParameterDirection.Input);

            return SqlMapper.Execute(_connectionFactory.GetConnection, EquipmentSql.Update, param: param,
                commandType: CommandType.StoredProcedure);
        }
        
    }
}
