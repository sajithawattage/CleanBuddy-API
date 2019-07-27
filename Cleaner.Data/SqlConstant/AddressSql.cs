namespace Cleaner.DataAccess.SqlConstant
{
    public class AddressSql
    {
        protected AddressSql() { }

        public static string GetAll
        { 
            get { return "SELECT * FROM Address"; }
        }

        public static string GetById
        {
            get { return "SELECT * FROM Address WHERE AddressID=@id"; }
        }

        public static string Insert
        {
            get { return "sp_AddressInsert"; }
        }

        public static string Update
        {
            get { return "sp_AddressUpdate"; }
        }

        public static string Delete
        {
            get { return "DELETE FROM Address WHERE Id=@id"; }
        }
    }
}
