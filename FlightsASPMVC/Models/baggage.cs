//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlightsASPMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class baggage
    {
        [Display(Name = "Baggage identifier")]
        public int id { get; set; }

        [Display(Name = "Baggage comment")]
        public string comment { get; set; }

        [Display(Name = "Owned by")]
        public int owned_by { get; set; }

        [Display(Name = "Receipt date")]
        public System.DateTime receipt_date { get; set; }

        [Display(Name = "Return date")]
        public Nullable<System.DateTime> return_date { get; set; }

        [Display(Name = "Passenger")]
        public virtual passenger passenger { get; set; }
    }
}
