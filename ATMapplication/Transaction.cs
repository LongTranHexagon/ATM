//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ATMapplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int TransactionID { get; set; }
        public int AccountID { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime DateTime { get; set; }
        public string Statement { get; set; }
    
        public virtual Account Account { get; set; }
    }
}