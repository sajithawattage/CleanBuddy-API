using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.SqlConstant
{
    public class ContractorSql
    {
        public const string GetAll = "SELECT * FROM Contractor";
        public const string GetById = "SELECT * FROM Contractor WHERE ContractorID=@id";
        public const string Insert = "sp_ContractorInsert";
        public const string Update = "sp_ContractorUpdate";
        public const string Delete = "DELETE FROM Contractor WHERE Id=@id";
    }
}
