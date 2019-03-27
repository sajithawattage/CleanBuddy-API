using Cleaner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
