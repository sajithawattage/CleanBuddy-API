namespace Cleaner.DataAccess.SqlConstant
{
    public class EmployeeSql
    {
        protected EmployeeSql() { }

        public static string GetAll
        {
            get
            {
                return "SELECT * FROM Employee";
            }
        }
        public static string GetById { get { return "SELECT * FROM Employee WHERE EmployeeID=@id"; } }
        public static string Insert { get { return "sp_EmployeeInsert"; } }
        public static string Update { get { return "sp_EmployeeUpdate"; } }
        public static string Delete { get { return "DELETE FROM Employee WHERE EmployeeID=@id"; } }
    }
}
