//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBusinessLogicLibrary.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee_cu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee_cu()
        {
            this.InventoryStore_cu = new HashSet<InventoryStore_cu>();
            this.InventoryStore_Employee_cu = new HashSet<InventoryStore_Employee_cu>();
            this.InventoryStoreCategory_cu = new HashSet<InventoryStoreCategory_cu>();
        }
    
        public long Person_CU_ID { get; set; }
        public Nullable<int> EmployeeType_CU_ID { get; set; }
        public string InternalCode { get; set; }
        public string AbbreviationName { get; set; }
        public Nullable<int> MilitaryStatus_P_ID { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> EmploymentDate { get; set; }
        public Nullable<System.DateTime> RetirementDate { get; set; }
    
        public virtual EmployeeType_cu EmployeeType_cu { get; set; }
        public virtual MilitaryStatus_p MilitaryStatus_p { get; set; }
        public virtual Person_cu Person_cu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryStore_cu> InventoryStore_cu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryStore_Employee_cu> InventoryStore_Employee_cu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryStoreCategory_cu> InventoryStoreCategory_cu { get; set; }
    }
}
