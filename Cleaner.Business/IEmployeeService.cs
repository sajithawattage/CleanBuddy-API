﻿using Cleaner.DataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;

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
