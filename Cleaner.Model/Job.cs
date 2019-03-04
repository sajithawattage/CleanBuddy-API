using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Model
{
    public class Job
    {
        public int ID { get; set; }
        public int SiteID { get; set; }
        public DateTime JobStartDate { get; set; }
    }
}
