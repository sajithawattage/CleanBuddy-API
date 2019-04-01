using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.SqlConstant
{
    public class JobEquipmentSql
    {
        public const string GetAll = "SELECT * FROM JobEquipment";
        public const string GetById = "SELECT * FROM JobEquipment WHERE ID=@id";
        public const string Insert = "sp_JobEquipmentInsert";
        public const string Update = "sp_JobEquipmentUpdate";
        public const string Delete = "DELETE FROM JobEquipment WHERE ID=@id";
    }
}
