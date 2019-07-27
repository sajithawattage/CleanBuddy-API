namespace Cleaner.DataAccess.SqlConstant
{
    public class ApproveGroupSql
    {
        protected ApproveGroupSql() { }

        public static string GetAll
        {
            get { return "SELECT * FROM ApproveGroup"; }
        }
        public static string GetById
        {
            get { return "SELECT * FROM ApproveGroup WHERE AddressID=@id"; }
        }
        public static string Insert
        {
            get { return "sp_ApproveGroupInsert"; }
        }
        public static string Update
        {
            get { return "sp_ApproveGroupUpdate"; }
        }
        public static string Delete
        {
            get { return "DELETE FROM ApproveGroup WHERE Id=@id"; }
        }
    }
}
