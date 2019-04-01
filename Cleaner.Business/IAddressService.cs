using Cleaner.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.Business
{
    public interface IAddressService
    {
        Task<IEnumerable<Address>> GetAddressList();
        Address GetAddressById(int id);
        bool SaveAddress(Address address);
        bool UpdateAddress(Address address);
        bool DeleteAddress(int id);
    }
}
