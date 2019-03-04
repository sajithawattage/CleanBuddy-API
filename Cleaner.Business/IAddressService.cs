using Cleaner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Business
{
    public interface IAddressService
    {
        IEnumerable<Address> GetAddressList();
        Address GetAddressById(int id);
        bool SaveAddress(Address address);
        bool UpdateAddress(Address address);
        bool DeleteAddress(int id);
    }
}
