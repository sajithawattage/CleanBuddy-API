using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.SqlConstant
{
    public class ApproveGroupSql
    {
        public const string GetAll = "SELECT * FROM ApproveGroup";
        public const string GetById = "SELECT * FROM ApproveGroup WHERE AddressID=@id";
        public const string Insert = "sp_ApproveGroupInsert";
        public const string Update = "sp_ApproveGroupUpdate";
        public const string Delete = "DELETE FROM ApproveGroup WHERE Id=@id";
    }
}
