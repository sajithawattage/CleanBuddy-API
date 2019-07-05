using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Model
{
    public class WorkType : BaseModel
    {
      
        public string WorkTypeName { get; set; }
    }
    public class WorkTypeList : List<WorkType> { }
}
