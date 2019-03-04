using Cleaner.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cleaner.DataAccess.Repositories
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        Task<IEnumerable<Employee>> GetAllActiveEmployeeList();
        Task<IEnumerable<Employee>> GetAllEmployeeList();
    }
}
