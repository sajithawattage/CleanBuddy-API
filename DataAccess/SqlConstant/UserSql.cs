using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.SqlConstant
{
    public class UserSql
    {
        public const string GetAll = "SELECT * FROM UserLogin";
        public const string GetById = "SELECT * FROM UserLogin WHERE Id=@id";
        public const string Insert = "dbo.sp_UserLoginInsert";
        public const string Update = "dbo.sp_UserLoginUpdate";
        public const string Delete = "DELETE FROM UserLogin WHERE Id=@id";
        public const string GetByUserName = "dbo.sp_UserLoginGetByUserName";
    }
}
