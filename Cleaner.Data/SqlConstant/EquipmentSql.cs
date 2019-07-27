namespace Cleaner.DataAccess.SqlConstant
{
    public class EquipmentSql
    {
        protected EquipmentSql() { }

        public static string GetAll { get { return "SELECT * FROM Equipment"; } }
        public static string GetById { get { return "SELECT * FROM Equipment WHERE Id=@id"; } }
        public static string Insert { get { return "dbo.sp_EquipmentInsert"; } }
        public static string Update { get { return "dbo.sp_EquipmentUpdate"; } }
        public static string Delete
        {
            get
            { return "DELETE FROM Equipment WHERE Id=@id"; }
        }
    }
}
