//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cleaner.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class ApproveGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ApproveGroup()
        {
            this.ApproveGroupUsers = new HashSet<ApproveGroupUser>();
            this.RequestHeaders = new HashSet<RequestHeader>();
        }
    
        public int GroupID { get; set; }
        public string GroupName { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApproveGroupUser> ApproveGroupUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestHeader> RequestHeaders { get; set; }
    }
}
