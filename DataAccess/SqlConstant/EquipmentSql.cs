using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.SqlConstant
{
    public class EquipmentSql
    {
        public const string GetAll  = "SELECT * FROM Equipment";
        public const string GetById = "SELECT * FROM Equipment WHERE Id=@id";
        public const string Insert  = "dbo.sp_EquipmentInsert";
        public const string Update  = "dbo.sp_EquipmentUpdate";
        public const string Delete  = "DELETE FROM Equipment WHERE Id=@id";

    }
}
