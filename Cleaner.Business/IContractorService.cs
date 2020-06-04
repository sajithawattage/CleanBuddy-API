using Cleaner.DataAccess;
using System.Collections.Generic;

namespace Cleaner.Business
{
    public interface IContractorService
    {
        IEnumerable<Contractor> GetContractorList();
        Contractor GetContractorById(int id);
        bool SaveContractor(Contractor contractor);
        bool UpdateContractor(Contractor contractor);
        bool DeleteContractor(int id);
    }
}
