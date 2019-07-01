using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Model
{
    public class ApproveGroupUser : BaseModel
    {
        public int GroupID { get; set; }
        public int UserID { get; set; }
    }
    public class ApproveGroupUserList : List<ApproveGroupUser> { }
}
