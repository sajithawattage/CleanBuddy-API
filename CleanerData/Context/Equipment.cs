//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cleaner.Data.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Equipment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Equipment()
        {
            this.JobEquipments = new HashSet<JobEquipment>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int CategoryID { get; set; }
        public string PurchasedFrom { get; set; }
        public System.DateTime PurchaseDate { get; set; }
        public System.DateTime WarrantyExpire { get; set; }
    
        public virtual EquipmentCategory EquipmentCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobEquipment> JobEquipments { get; set; }
    }
}
