using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.SqlConstant
{
    public class JobEmployeeSql
    {
        public const string GetAll = "SELECT * FROM ContractorEmployee";
        public const string GetById = "SELECT * FROM ContractorEmployee WHERE AddressID=@id";
        public const string Insert = "sp_AddressInsert";
        public const string Update = "sp_AddressUpdate";
        public const string Delete = "DELETE FROM Address WHERE Id=@id";
    }
}
