using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Model
{
    public class Employee : BaseModel
    {
       
        public string EmployeeName { get; set; }
        public int EmployeeContactNo { get; set; }
    }
    public class EmployeeList : List<Employee> { }
}
