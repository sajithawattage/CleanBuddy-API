using Cleaner.DataAccess;
using System.Collections.Generic;

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
