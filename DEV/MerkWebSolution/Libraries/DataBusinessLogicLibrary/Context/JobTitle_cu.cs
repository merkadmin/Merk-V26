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
    
    public partial class JobTitle_cu
    {
        public int ID { get; set; }
        public string Name_P { get; set; }
        public string Name_S { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsOnDuty { get; set; }
        public Nullable<long> InsertedBy { get; set; }
        public Nullable<System.DateTime> InsertedDate { get; set; }
    
        public virtual User_cu User_cu { get; set; }
    }
}
