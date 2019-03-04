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
    public class AddressRepository : IGenericRepository<Address>, IAddressRepository
    {
        IConnectionFactory _connectionFactory;

        public AddressRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public int Add(Address entity)
        {
            DynamicParameters param = new DynamicParameters();
            
            param.Add("@Name", entity.Name, DbType.String, ParameterDirection.Input);
            param.Add("@StreetAddress", entity.StreetAddress, DbType.String, ParameterDirection.Input);
            param.Add("@City", entity.City, DbType.String, ParameterDirection.Input);
            param.Add("@PostalCode", entity.PostalCode, DbType.Int32, ParameterDirection.Input);
            param.Add("@State", entity.State, DbType.String, ParameterDirection.Input);
            param.Add("@Country", entity.Country, DbType.Single, ParameterDirection.Input);

            return SqlMapper.Execute(_connectionFactory.GetConnection, AddressSql.Insert, param: param,
                commandType: CommandType.StoredProcedure);
        }

        public int Delete(int id)
        {
            return SqlMapper.Execute(_connectionFactory.GetConnection, AddressSql.Delete,
                 new { id = id }, commandType: CommandType.Text);
        }

        public Address Get(int id)
        {
            var address = SqlMapper.QueryFirst<Address>(_connectionFactory.GetConnection, AddressSql.GetById,
                new { AddressID = id }, commandType: CommandType.Text);
            return address;
        }

        public IEnumerable<Address> GetAll()
        {
            return SqlMapper.Query<Address>(_connectionFactory.GetConnection, AddressSql.GetAll,
                commandType: CommandType.Text).ToList();
        }

        public int Update(Address entity)
        {
            DynamicParameters param = new DynamicParameters();

            param.Add("@AddressID", entity.AddressID, DbType.String, ParameterDirection.Input);
            param.Add("@Name", entity.Name, DbType.String, ParameterDirection.Input);
            param.Add("@StreetAddress", entity.StreetAddress, DbType.String, ParameterDirection.Input);
            param.Add("@City", entity.City, DbType.String, ParameterDirection.Input);
            param.Add("@PostalCode", entity.PostalCode, DbType.Int32, ParameterDirection.Input);
            param.Add("@State", entity.State, DbType.String, ParameterDirection.Input);
            param.Add("@Country", entity.Country, DbType.Single, ParameterDirection.Input);
            
            return SqlMapper.Execute(_connectionFactory.GetConnection, AddressSql.Update, param: param,
                commandType: CommandType.StoredProcedure);
        }
    }
}
