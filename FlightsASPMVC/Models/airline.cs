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
    
    public partial class airline
    {
        public airline()
        {
            this.plane = new HashSet<plane>();
            this.airport = new HashSet<airport>();
        }

        [Display(Name = "Airline identifier")]
        public int id { get; set; }

        [Display(Name = "Airline")]
        public string name { get; set; }
    
        public virtual ICollection<plane> plane { get; set; }
        public virtual ICollection<airport> airport { get; set; }
    }
}
