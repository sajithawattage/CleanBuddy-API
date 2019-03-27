using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.SqlConstant
{
    public class ApproveGroupUserSql
    {
        public const string GetAll = "SELECT * FROM [dbo].[ApproveGroupUser]";
        public const string GetById = "SELECT * FROM [dbo].[ApproveGroupUser] WHERE ID=@id";
        public const string Insert = "[dbo].[sp_ApproveGroupUserInsert]";
        public const string Update = "[dbo].[sp_ApproveGroupUserUpdate]";
        public const string Delete = "DELETE FROM [dbo].[ApproveGroupUser] WHERE Id=@id";
    }
}
