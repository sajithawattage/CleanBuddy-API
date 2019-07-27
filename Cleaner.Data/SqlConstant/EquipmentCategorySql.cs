namespace Cleaner.DataAccess.SqlConstant
{
    public class EquipmentCategorySql
    {
        public static string GetAll
        {
            get
            {
                return "SELECT * FROM EquipmentCategory";
            }
        }
        public static string GetById { get { return "SELECT * FROM EquipmentCategory WHERE Id=@id"; } }
        public static string Insert { get { return "dbo.sp_EquipmentCategoryInsert"; } }
        public static string Update { get { return "dbo.sp_EquipmentCategoryUpdate"; } }
        public static string Delete { get { return "DELETE FROM EquipmentCategory WHERE Id=@id"; } }
    }
}
