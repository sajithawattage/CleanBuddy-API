using Cleaner.Model;
using System.Collections.Generic;

namespace Cleaner.Business
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployeeList();
        Employee GetEmployeeById(int id);
        bool SaveEmployee(Employee employee);
        bool UpdateEmployee(Employee employee);
        bool DeleteEmployee(int id);
    }
}
