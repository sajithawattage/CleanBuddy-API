using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Model
{
    public class ApproveGroup : BaseModel
    {
        public string GroupName { get; set; }
        public string Description { get; set; }
    }

    public class ApproveGroupList : List<BaseModel> { }
}
