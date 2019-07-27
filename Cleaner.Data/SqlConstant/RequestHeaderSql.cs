namespace Cleaner.DataAccess.SqlConstant
{
    public class RequestHeaderSql
    {
        public static string GetAll
        {
            get
            {
                return "SELECT * FROM RequestHeader";
            }
        }
        public static string GetById { get { return "SELECT * FROM RequestHeader WHERE ID=@id"; } }
        public static string Insert  { get { return  "sp_RequestHeaderInsert"; } }
        public static string Update  { get { return  "sp_RequestHeaderUpdate"; } }
        public static string Delete  { get { return  "DELETE FROM RequestHeader WHERE Id=@id"; } }
    }
}
