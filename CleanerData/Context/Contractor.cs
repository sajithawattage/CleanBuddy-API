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
    
    public partial class Contractor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contractor()
        {
            this.ContractorEmployees = new HashSet<ContractorEmployee>();
            this.Sites = new HashSet<Site>();
            this.SubContractors = new HashSet<SubContractor>();
        }
    
        public int ContractorID { get; set; }
        public int AddressID { get; set; }
        public string Name { get; set; }
        public string EmailID { get; set; }
        public string ContactPerson { get; set; }
        public Nullable<int> ContactNo { get; set; }
        public string ABN { get; set; }
        public Nullable<int> PaymentOption { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public string Note { get; set; }
    
        public virtual Address Address { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContractorEmployee> ContractorEmployees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Site> Sites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubContractor> SubContractors { get; set; }
    }
}
