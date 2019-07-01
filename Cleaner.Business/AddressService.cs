using System.Collections.Generic;
using Cleaner.Model;
using Cleaner.DataAccess.Repositories;
using System.Threading.Tasks;
using Cleaner.DataAccess.UnitOfWork;

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

        public Task<IEnumerable<Address>> GetAddressList()
        {
            _unitOfWork.AddressRepository<Address>().GetAll();
            return null;
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
