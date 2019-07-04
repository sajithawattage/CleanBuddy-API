using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Model
{
    public class JobEquipment : BaseModel
    {
       
        public int? JobID { get; set; }
        public int EquipmentID { get; set; }
    }
    public class JobEquipmentList : List<JobEquipment> { }
}
