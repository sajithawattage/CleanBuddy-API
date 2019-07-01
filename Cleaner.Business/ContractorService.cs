using System;
using System.Collections.Generic;
using Cleaner.Model;
using Cleaner.DataAccess.Repositories;
using System.Threading.Tasks;
using Cleaner.DataAccess.UnitOfWork;

namespace Cleaner.Business
{
    public class ContractorService : IContractorService
    {
        private IUnitOfWork _unitOfWork = null;

        public ContractorService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public bool DeleteContractor(int id)
        {
            this._unitOfWork.ContractorRepository<Contractor>().Delete(id);
            return false;
        }

        public Contractor GetContractorById(int id)
        {
            return this._unitOfWork.ContractorRepository<Contractor>().GetByID(id);
        }

        public IEnumerable<Contractor> GetContractorList()
        {
            return this._unitOfWork.ContractorRepository<Contractor>().GetAll();
        }

        public bool SaveContractor(Contractor contractor)
        {
            this._unitOfWork.ContractorRepository<Contractor>().Insert(contractor);
            return false;
        }

        public bool UpdateContractor(Contractor contractor)
        {
            this._unitOfWork.ContractorRepository<Contractor>().Update(contractor);
            return false;
        }
    }
}
