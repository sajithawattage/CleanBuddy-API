using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner.Model
{
    public class Equipment
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int CategoryID { get; set; }
        public string PurchasedFrom { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime WarrantyExpire { get; set; }
    }
}
