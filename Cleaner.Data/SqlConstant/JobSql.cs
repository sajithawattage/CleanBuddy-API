namespace Cleaner.DataAccess.SqlConstant
{
    public class JobSql
    {
        protected JobSql() { }

        public static string GetAll
        {
            get
            {
                return "SELECT * FROM Job";
            }
        }
        public static string GetById { get { return "SELECT * FROM Job WHERE ID=@id"; } }
        public static string Insert { get { return "sp_JobInsert"; } }
        public static string Update { get { return "sp_JobUpdate"; } }
        public static string Delete { get { return "DELETE FROM Job WHERE ID=@id"; } }
    }
}
