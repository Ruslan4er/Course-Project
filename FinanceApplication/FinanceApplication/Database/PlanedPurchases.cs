//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinanceApplication.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlanedPurchases
    {
        public int PPUID { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public bool Status { get; set; }
        public int AccountUID { get; set; }
    
        public virtual Account Account { get; set; }
    }
}