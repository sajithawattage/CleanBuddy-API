using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Model
{
    public class EquipmentCategory : BaseModel
    {
       
        public string Name { get; set; }
    }
    public class EquipmentCategoryList : List<EquipmentCategory> { }
}
