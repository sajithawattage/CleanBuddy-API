using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Model
{
    public class SiteSubContractor: BaseModel
    {
        public int SubContractorID { get; set; }
        public string ReportingOfficer { get; set; }
        public int SiteID { get; set; }
    }
    public class SiteSubContractorList : List<SiteSubContractor> { }
}
