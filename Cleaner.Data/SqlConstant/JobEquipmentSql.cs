namespace Cleaner.DataAccess.SqlConstant
{
    public class JobEquipmentSql
    {
        protected JobEquipmentSql() { }

        public static string GetAll
        {
            get
            {
                return "SELECT * FROM JobEquipment";
            }
        }
        public static string GetById { get { return "SELECT * FROM JobEquipment WHERE ID=@id"; } }
        public static string Insert { get { return "sp_JobEquipmentInsert"; } }
        public static string Update { get { return "sp_JobEquipmentUpdate"; } }
        public static string Delete { get { return "DELETE FROM JobEquipment WHERE ID=@id"; } }
    }
}
