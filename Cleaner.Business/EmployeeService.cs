using Cleaner.DataAccess.UnitOfWork;
using Cleaner.Model;
using System.Collections.Generic;
using System.Linq;

namespace Cleaner.Business
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork = null;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool DeleteEmployee(int id)
        {
            _unitOfWork.EmployeeRepository<Employee>().Delete(id);
            return false;
        }

        public Employee GetEmployeeById(int id)
        {
            return _unitOfWork.EmployeeRepository<Employee>().GetByID(id);
        }

        public IEnumerable<Employee> GetEmployeeList()
        {
            return _unitOfWork.EmployeeRepository<DataAccess.Employee>().GetAll().Select(x => new Employee
            {
                Name = x.Name,
                BirthDate = x.BirthDate,
                ContactNo = x.ContactNo,
                CurrentFlag = x.CurrentFlag,
                EmployeeID = x.EmployeeID,
                Gender = x.Gender,
                HireDate = x.HireDate,
                JobTitle = x.JobTitle,
                MaritalStatus = x.MaritalStatus,
                NationalIDNumber = x.NationalIDNumber,
                OrganizationLevel = x.OrganizationLevel,
                SickLeaveHours = x.SickLeaveHours,
                VacationHours = x.VacationHours,
                SalariedFlag = x.SalariedFlag,
                ParttimeFlag = x.ParttimeFlag,
                LoginID = x.LoginID,
                rowguid = x.rowguid
            });
        }

        public bool SaveEmployee(Employee employee)
        {
            _unitOfWork.EmployeeRepository<DataAccess.Employee>().Insert(new DataAccess.Employee {
                Name = employee.Name,
                BirthDate = employee.BirthDate,
                ContactNo = employee.ContactNo,
                CurrentFlag = employee.CurrentFlag,
                EmployeeID = employee.EmployeeID,
                Gender = employee.Gender,
                HireDate = employee.HireDate,
                JobTitle = employee.JobTitle,
                LoginID = employee.LoginID,
                MaritalStatus = employee.MaritalStatus,
                NationalIDNumber = employee.NationalIDNumber,
                OrganizationLevel = employee.OrganizationLevel,
                ParttimeFlag = employee.ParttimeFlag,
                rowguid = System.Guid.NewGuid(),
                SalariedFlag = employee.SalariedFlag,
                SickLeaveHours = employee.SickLeaveHours,
                VacationHours = employee.VacationHours
            });
            return true;
        }

        public bool UpdateEmployee(Employee employee)
        {
            this._unitOfWork.EmployeeRepository<DataAccess.Employee>().Update(new DataAccess.Employee
            {
                Name = employee.Name,
                BirthDate = employee.BirthDate,
                ContactNo = employee.ContactNo,
                CurrentFlag = employee.CurrentFlag,
                EmployeeID = employee.EmployeeID,
                Gender = employee.Gender,
                HireDate = employee.HireDate,
                JobTitle = employee.JobTitle,
                LoginID = employee.LoginID,
                MaritalStatus = employee.MaritalStatus,
                NationalIDNumber = employee.NationalIDNumber,
                OrganizationLevel = employee.OrganizationLevel,
                ParttimeFlag = employee.ParttimeFlag,
                rowguid = System.Guid.NewGuid(),
                SalariedFlag = employee.SalariedFlag,
                SickLeaveHours = employee.SickLeaveHours,
                VacationHours = employee.VacationHours
            });
            return false;
        }
    }
}
