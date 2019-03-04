using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Model
{
    public class Address
    {
        public int AddressID { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
    }
}
