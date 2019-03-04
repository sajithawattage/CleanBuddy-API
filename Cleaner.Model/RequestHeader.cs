using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Model
{
    public class RequestHeader
    {
        public int ID { get; set; }
        public int RequestID { get; set; }
        public int GroupID { get; set; }
        public int EmployeeID { get; set; }
        public int JobID { get; set; }
        public DateTime RequestDateTime { get; set; }
        public int ApproveGroupID { get; set; }
        public string ApproveStatus { get; set; }
        public DateTime ApprovedDateTime { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
