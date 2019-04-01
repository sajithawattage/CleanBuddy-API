using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.SqlConstant
{
    public class JobSql
    {
        public const string GetAll = "SELECT * FROM Job";
        public const string GetById = "SELECT * FROM Job WHERE ID=@id";
        public const string Insert = "sp_JobInsert";
        public const string Update = "sp_JobUpdate";
        public const string Delete = "DELETE FROM Job WHERE ID=@id";
    }
}
