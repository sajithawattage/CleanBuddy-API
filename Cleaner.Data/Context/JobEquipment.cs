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
    
    public partial class JobEquipment
    {
        public int ID { get; set; }
        public int JobID { get; set; }
        public int EquipmentID { get; set; }
    
        public virtual Equipment Equipment { get; set; }
        public virtual Job Job { get; set; }
    }
}
