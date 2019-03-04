using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.SqlConstant
{
    public class AddressSql
    {
        public const string GetAll = "SELECT * FROM Address";
        public const string GetById = "SELECT * FROM Address WHERE AddressID=@id";
        public const string Insert = "sp_AddressInsert";
        public const string Update = "sp_AddressUpdate";
        public const string Delete = "DELETE FROM AddressSql WHERE Id=@id";
    }
}
