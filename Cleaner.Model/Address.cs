using System.Collections.Generic;

namespace Cleaner.Model
{
    public class Address : BaseModel
    {
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
    }

    public class AddressList : List<Address> { }
}
