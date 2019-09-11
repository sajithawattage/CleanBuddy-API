using Cleaner.DataAccess.UnitOfWork;
using Cleaner.Model;
using System.Collections.Generic;
using System.Linq;

namespace Cleaner.Business
{
    public class AddressService : IAddressService
    {
        private IUnitOfWork _unitOfWork = null;

        public AddressService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public bool DeleteAddress(int id)
        {
            _unitOfWork.AddressRepository<Address>().Delete(id);
            return true;
        }

        public Address GetAddressById(int id)
        {
            return _unitOfWork.AddressRepository<Address>().GetByID(id);
        }

        public IEnumerable<Address> GetAddressList()
        {
            return _unitOfWork.AddressRepository<DataAccess.Address>().GetAll().Select(x => new Address
            {
                City = x.City,
                Name = x.Name,
                StreetAddress = x.StreetAddress,
                Country = x.Country,
                Id = x.AddressID,
                PostalCode = x.PostalCode,
                State = x.State
            });
        }

        public bool SaveAddress(Address address)
        {
            _unitOfWork.AddressRepository<Address>().Insert(address);
            return true;
        }

        public bool UpdateAddress(Address address)
        {
            _unitOfWork.AddressRepository<Address>().Update(address);
            return true;
        }
    }
}
