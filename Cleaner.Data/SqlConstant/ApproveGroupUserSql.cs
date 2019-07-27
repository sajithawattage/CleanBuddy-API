namespace Cleaner.DataAccess.SqlConstant
{
    public class ApproveGroupUserSql
    {
        public static string GetAll
        {
            get
            {
                return "SELECT * FROM [dbo].[ApproveGroupUser]";
            }
        }
        public static string GetById
        {
            get
            {
                return "SELECT * FROM [dbo].[ApproveGroupUser] WHERE ID=@id";
            }
        }
        public static string Insert
        {
            get
            {
                return "[dbo].[sp_ApproveGroupUserInsert]";
            }
        }
        public static string Update
        {
            get
            {
                return "[dbo].[sp_ApproveGroupUserUpdate]";
            }
        }
        public static string Delete
        {
            get
            { return "DELETE FROM [dbo].[ApproveGroupUser] WHERE Id=@id"; }
        }
    }
}
