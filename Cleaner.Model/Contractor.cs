using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Model
{
    public class Contractor : BaseModel
    {

        public int AddressID { get; set; }
        public string Name { get; set; }
        public string EmailID { get; set; }
        public string ContactPerson { get; set; }
        public int ContactNo { get; set; }
        public string ABN { get; set; }
        public int PaymentOption { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Note { get; set; }

    }
    public class ContractorList : List<BaseModel> { }
}
