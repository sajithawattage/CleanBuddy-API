using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Model
{
    public class UserAccount
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public int UserRoleID { get; set; }
        public int EmployeeID { get; set; }
    }
}
