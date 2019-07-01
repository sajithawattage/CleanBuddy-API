using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Model
{
    public class SubContractor : BaseModel
    {
        
        public int ContractorID { get; set; }
        public string Name { get; set; }
        public int AddressID { get; set; }
        public string ABN { get; set; }
        public string EmailAddress { get; set; }
    }

    public class SubContractorList : List<SubContractor> { }
}
