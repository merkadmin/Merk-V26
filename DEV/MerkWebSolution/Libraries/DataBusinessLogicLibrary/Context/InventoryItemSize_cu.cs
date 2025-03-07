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
    
    public partial class InventoryItemSize_cu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InventoryItemSize_cu()
        {
            this.InventoryItemGroupingItem_cu = new HashSet<InventoryItemGroupingItem_cu>();
            this.InventoryItemOffers_cu = new HashSet<InventoryItemOffers_cu>();
        }
    
        public int ID { get; set; }
        public string Name_P { get; set; }
        public string Name_S { get; set; }
        public int InventoryItem_CU_ID { get; set; }
        public int InventoryItemSize_P_ID { get; set; }
        public double SellingPrice { get; set; }
        public bool IsOnDuty { get; set; }
        public long InsertedBy { get; set; }
        public Nullable<System.DateTime> InsertedDate { get; set; }
    
        public virtual InventoryItem_cu InventoryItem_cu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryItemGroupingItem_cu> InventoryItemGroupingItem_cu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryItemOffers_cu> InventoryItemOffers_cu { get; set; }
        public virtual InventoryItemSize_P InventoryItemSize_P { get; set; }
        public virtual User_cu User_cu { get; set; }
    }
}
