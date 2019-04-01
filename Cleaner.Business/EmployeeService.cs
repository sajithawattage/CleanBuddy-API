using System;
using System.Collections.Generic;
using Cleaner.Model;
using Cleaner.DataAccess.Repositories;
using System.Threading.Tasks;

namespace Cleaner.Business
{
    public class EmployeeService : IEmployeeService
    {
        IEmployeeRepository _employeeRepo;

        public EmployeeService(IEmployeeRepository employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public bool DeleteEmployee(int id)
        {
            return (_employeeRepo.Delete(id) > 0) ? true : false;
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeRepo.Get(id);
        }

        public Task<IEnumerable<Employee>> GetEmployeeList()
        {
            return _employeeRepo.GetAll();
        }

        public bool SaveEmployee(Employee employee)
        {
            return (_employeeRepo.Add(employee) > 0) ? true : false;
        }

        public bool UpdateEmployee(Employee employee)
        {
            return (_employeeRepo.Update(employee) > 0) ? true : false;
        }
    }
}
