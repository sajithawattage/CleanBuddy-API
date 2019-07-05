using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Model
{
    public class Job : BaseModel
    {

        public int SiteID { get; set; }
        public DateTime JobStartDate { get; set; }
        public JobEquipmentList JobEquipmentList { get; set; }
    }

    public class JobList : List<Job> { }
}
