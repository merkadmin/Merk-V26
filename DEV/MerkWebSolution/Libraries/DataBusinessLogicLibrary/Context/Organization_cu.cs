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
    
    public partial class Organization_cu
    {
        public int ID { get; set; }
        public int Organization_P_ID { get; set; }
        public string Name_P { get; set; }
        public string Name_S { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhone1 { get; set; }
        public string OwnerPhone2 { get; set; }
        public string OwnserEmail { get; set; }
        public string OrganizationEmail { get; set; }
        public string GMAILPassword { get; set; }
        public string OraganizationAddress { get; set; }
        public string Description { get; set; }
        public bool IsOnDuty { get; set; }
        public long InsertedBy { get; set; }
        public Nullable<System.DateTime> InsertedDate { get; set; }
    
        public virtual Organization_p Organization_p { get; set; }
        public virtual User_cu User_cu { get; set; }
    }
}
