using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.SqlConstant
{
    public class EquipmentCategorySql
    {
        public const string GetAll = "SELECT * FROM EquipmentCategory";
        public const string GetById = "SELECT * FROM EquipmentCategory WHERE Id=@id";
        public const string Insert = "dbo.sp_EquipmentCategoryInsert";
        public const string Update = "dbo.sp_EquipmentCategoryUpdate";
        public const string Delete = "DELETE FROM EquipmentCategory WHERE Id=@id";
    }
}
