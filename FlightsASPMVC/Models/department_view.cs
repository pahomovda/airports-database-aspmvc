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
    
    public partial class department_view
    {
        [Display(Name = "Department identifier")]
        public int id { get; set; }

        [Display(Name = "Department name")]
        public string departnent_name { get; set; }

        [Display(Name = "Head name")]
        public string head_name { get; set; }

        [Display(Name = "Head lastname")]
        public string head_lastname { get; set; }

        [Display(Name = "List of brigades")]
        public string brigades { get; set; }
    }
}
