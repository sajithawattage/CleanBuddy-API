using System.Collections.Generic;

namespace Cleaner.Model
{
    public class Employee : BaseModel
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int ContactNo { get; set; }
        public string NationalIDNumber { get; set; }
        public string LoginID { get; set; }
        public int OrganizationLevel { get; set; }
        public string JobTitle { get; set; }        
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public bool SalariedFlag { get; set; }
        public short VacationHours { get; set; }
        public short SickLeaveHours { get; set; }
        public bool CurrentFlag { get; set; }
        public bool ParttimeFlag { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime BirthDate { get; set; }
        public System.DateTime HireDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
    public class EmployeeList : List<Employee> { }
}
