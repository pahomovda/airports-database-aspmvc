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
    
    public partial class plane
    {
        public plane()
        {
            this.flight = new HashSet<flight>();
            this.plane_repairs = new HashSet<plane_repairs>();
            this.plane_inspections = new HashSet<plane_inspections>();
        }

        [Display(Name = "Plane identifier")]
        public int id { get; set; }
        public int airline { get; set; }
        public int model { get; set; }
    
        public virtual airline airline1 { get; set; }
        public virtual ICollection<flight> flight { get; set; }
        public virtual ICollection<plane_repairs> plane_repairs { get; set; }
        public virtual plane_model plane_model { get; set; }
        public virtual ICollection<plane_inspections> plane_inspections { get; set; }
    }
}