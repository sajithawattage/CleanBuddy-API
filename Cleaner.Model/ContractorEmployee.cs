using System;
using System.Collections.Generic;

namespace Cleaner.Model
{
    public class ContractorEmployee : BaseModel
    {
        public int EmployeeJobID { get; set; }
        public int ContractorID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime JoinDate { get; set; }
    }
    public class ContractorEmployeeList : List<ContractorEmployee> { }
}
