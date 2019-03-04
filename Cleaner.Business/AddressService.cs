using System.Collections.Generic;
using Cleaner.Model;
using Cleaner.DataAccess.Repositories;

namespace Cleaner.Business
{
    public class AddressService : IAddressService
    {
        IAddressRepository _addressRepo;

        public AddressService(IAddressRepository addressRepo)
        {
            _addressRepo = addressRepo;
        }

        public bool DeleteAddress(int id)
        {
            return (_addressRepo.Delete(id) > 0) ? true : false;
        }

        public Address GetAddressById(int id)
        {
            return _addressRepo.Get(id);
        }

        public IEnumerable<Address> GetAddressList()
        {
            return _addressRepo.GetAll();
        }

        public bool SaveAddress(Address address)
        {
            return (_addressRepo.Add(address)> 0) ? true : false;
        }

        public bool UpdateAddress(Address address)
        {
            return (_addressRepo.Update(address) > 0) ? true : false;
        }
    }
}
