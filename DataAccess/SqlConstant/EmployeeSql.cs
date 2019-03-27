using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.SqlConstant
{
    public class EmployeeSql
    {
        public const string GetAll = "SELECT * FROM Employee";
        public const string GetById = "SELECT * FROM Employee WHERE EmployeeID=@id";
        public const string Insert = "sp_EmployeeInsert";
        public const string Update = "sp_EmployeeUpdate";
        public const string Delete = "DELETE FROM Employee WHERE EmployeeID=@id";
    }
}
