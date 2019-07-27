namespace Cleaner.DataAccess.SqlConstant
{
    public class ContractorSql
    {
        protected ContractorSql() { }

        public static string GetAll { get { return "SELECT * FROM Contractor"; } }
        public static string GetById { get { return "SELECT * FROM Contractor WHERE ContractorID=@id"; } }
        public static string Insert { get { return "sp_ContractorInsert"; } }
        public static string Update { get { return "sp_ContractorUpdate"; } }
        public static string Delete
        {
            get
            { return "DELETE FROM Contractor WHERE Id=@id"; }
        }
    }
}
