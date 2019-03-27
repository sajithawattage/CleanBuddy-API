using System;
using System.Collections.Generic;
using Cleaner.Model;
using Cleaner.DataAccess.Repositories;

namespace Cleaner.Business
{
    public class ContractorService : IContractorService
    {
        IContractorRepository _contractorRepository;

        public ContractorService(IContractorRepository contractorRepository)
        {
            _contractorRepository = contractorRepository;
        }

        public bool DeleteContractor(int id)
        {
            return (_contractorRepository.Delete(id) > 0) ? true : false;
        }

        public Contractor GetContractorById(int id)
        {
            return _contractorRepository.Get(id);
        }

        public IEnumerable<Contractor> GetContractorList()
        {
            return _contractorRepository.GetAll();
        }

        public bool SaveContractor(Contractor contractor)
        {
            return (_contractorRepository.Add(contractor) > 0) ? true : false;
        }

        public bool UpdateContractor(Contractor contractor)
        {
            return (_contractorRepository.Update(contractor) > 0) ? true : false;
        }
    }
}
