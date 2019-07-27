namespace Cleaner.DataAccess.SqlConstant
{
    public class UserSql
    {
        protected UserSql() { }

        public static string GetAll
        {
            get
            {
                return "SELECT * FROM UserLogin";
            }
        }
        public static string GetById { get { return "SELECT * FROM UserLogin WHERE Id=@id"; } }
        public static string Insert { get { return "dbo.sp_UserLoginInsert"; } }
        public static string Update { get { return "dbo.sp_UserLoginUpdate"; } }
        public static string Delete { get { return "DELETE FROM UserLogin WHERE Id=@id"; } }
        public static string GetByUserName
        {
            get
            {
                return "dbo.sp_UserLoginGetByUserName";
            }
        }
    }
}
