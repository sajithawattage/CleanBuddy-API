namespace Cleaner.DataAccess.SqlConstant
{
    public class RequestHeaderSql
    {
        public const string GetAll = "SELECT * FROM RequestHeader";
        public const string GetById = "SELECT * FROM RequestHeader WHERE ID=@id";
        public const string Insert = "sp_RequestHeaderInsert";
        public const string Update = "sp_RequestHeaderUpdate";
        public const string Delete = "DELETE FROM RequestHeader WHERE Id=@id";
    }
}
