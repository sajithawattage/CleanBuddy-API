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
    public class ContractorRepository : IContractorRepository
    {
        IConnectionFactory _connectionFactory;

        public ContractorRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public int Add(Contractor entity)
        {
            DynamicParameters param = new DynamicParameters();

            param.Add("@AddressID", entity.AddressID, DbType.Int32, ParameterDirection.Input);
            param.Add("@Name", entity.Name, DbType.String, ParameterDirection.Input);
            param.Add("@EmailID", entity.EmailID, DbType.String, ParameterDirection.Input);
            param.Add("@ContactPerson", entity.ContactPerson, DbType.String, ParameterDirection.Input);
            param.Add("@ContactNo", entity.ContactNo, DbType.Int32, ParameterDirection.Input);
            param.Add("@ABN", entity.ABN, DbType.String, ParameterDirection.Input);
            param.Add("@PaymentOption", entity.PaymentOption, DbType.Int32, ParameterDirection.Input);
            param.Add("@InvoiceDate", entity.InvoiceDate, DbType.Date, ParameterDirection.Input);
            param.Add("@Note", entity.Note, DbType.String, ParameterDirection.Input);

            return SqlMapper.Execute(_connectionFactory.GetConnection, ContractorSql.Insert, param: param,
                commandType: CommandType.StoredProcedure);
        }

        public int Delete(int id)
        {
            return SqlMapper.Execute(_connectionFactory.GetConnection, ContractorSql.Delete,
                new { id = id }, commandType: CommandType.Text);
        }

        public Contractor Get(int id)
        {
            var contractor = SqlMapper.QueryFirst<Contractor>(_connectionFactory.GetConnection, ContractorSql.GetById,
                new { ContractorID = id }, commandType: CommandType.Text);
            return contractor ;
        }

        public IEnumerable<Contractor> GetAll()
        {
            return SqlMapper.Query<Contractor>(_connectionFactory.GetConnection, ContractorSql.GetAll,
              commandType: CommandType.Text).ToList();
        }

        public Task<IEnumerable<Contractor>> GetAllActiveContractorList()
        {
            throw new NotImplementedException();
        }

        public int Update(Contractor entity)
        {
            DynamicParameters param = new DynamicParameters();

            param.Add("@ContractorID", entity.ContractorID, DbType.Int32, ParameterDirection.Input);
            param.Add("@AddressID", entity.AddressID, DbType.Int32, ParameterDirection.Input);
            param.Add("@Name", entity.Name, DbType.String, ParameterDirection.Input);
            param.Add("@EmailID", entity.EmailID, DbType.String, ParameterDirection.Input);
            param.Add("@ContactPerson", entity.ContactPerson, DbType.String, ParameterDirection.Input);
            param.Add("@ContactNo", entity.ContactNo, DbType.Int32, ParameterDirection.Input);
            param.Add("@ABN", entity.ABN, DbType.String, ParameterDirection.Input);
            param.Add("@PaymentOption", entity.PaymentOption, DbType.Int32, ParameterDirection.Input);
            param.Add("@InvoiceDate", entity.InvoiceDate, DbType.Date, ParameterDirection.Input);
            param.Add("@Note", entity.Note, DbType.String, ParameterDirection.Input);

            return SqlMapper.Execute(_connectionFactory.GetConnection, ContractorSql.Update, param: param,
                commandType: CommandType.StoredProcedure);
        }
    }
}
