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
    
    public partial class Organization_Application_p
    {
        public int ID { get; set; }
        public int Organization_P_ID { get; set; }
        public int Application_P_ID { get; set; }
    
        public virtual Application_p Application_p { get; set; }
        public virtual Organization_p Organization_p { get; set; }
    }
}
