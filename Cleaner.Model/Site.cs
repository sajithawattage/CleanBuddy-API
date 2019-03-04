using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Model
{
    public class Site
    {
        public int ID { get; set; }
        public int WorkTypeID { get; set; }
        public int AddressID { get; set; }
        public int ContractorID { get; set; }
        public string SiteName { get; set; }
        public int WorkType { get; set; }
        public string Notes { get; set; }
        public int Budget { get; set; }
        public int Allocation { get; set; }
        public int WorkDays { get; set; }
    }
}
