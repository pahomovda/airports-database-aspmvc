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
    
    public partial class brigade_list
    {
        [Display(Name = "Brigade identifier")]
        public int brigade { get; set; }

        [Display(Name = "List of individuals")]
        public string brigades { get; set; }
    }
}
