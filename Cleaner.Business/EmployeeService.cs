using System.Collections.Generic;
using Cleaner.DataAccess.UnitOfWork;
using Cleaner.DataAccess;

namespace Cleaner.Business
{
    public class EmployeeService : IEmployeeService
    {
        private IUnitOfWork _unitOfWork = null;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public bool DeleteEmployee(int id)
        {
            this._unitOfWork.EmployeeRepository<Employee>().Delete(id);
            return false;
        }

        public Employee GetEmployeeById(int id)
        {
            return this._unitOfWork.EmployeeRepository<Employee>().GetByID(id);
        }

        public IEnumerable<Employee> GetEmployeeList()
        {
            return this._unitOfWork.EmployeeRepository<Employee>().GetAll();
        }

        public bool SaveEmployee(Employee employee)
        {
            this._unitOfWork.EmployeeRepository<Employee>().Insert(employee);
            return false;
        }

        public bool UpdateEmployee(Employee employee)
        {
            this._unitOfWork.EmployeeRepository<Employee>().Update(employee);
            return false;
        }
    }
}
