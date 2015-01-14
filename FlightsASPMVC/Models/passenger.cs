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
    
    public partial class passenger
    {
        public passenger()
        {
            this.baggage = new HashSet<baggage>();
            this.ticket = new HashSet<ticket>();
        }

        [Display(Name = "Passenger identifier")]
        public int id { get; set; }

        [Display(Name = "Passenger name")]
        public string name { get; set; }

        [Display(Name = "Passenger lastname")]
        public string lastname { get; set; }

        [Display(Name = "Passenger patronymic")]
        public string patronymic { get; set; }

        [Display(Name = "Phone")]
        public string phone { get; set; }

        [Display(Name = "Additional phone")]
        public string additional_phone { get; set; }

        [Display(Name = "Comment")]
        public string comment { get; set; }

        [Display(Name = "City")]
        public int city { get; set; }

        [Display(Name = "Age")]
        public sbyte age { get; set; }

        [Display(Name = "Passport number")]
        public int passport_num { get; set; }

        [Display(Name = "Internationlal passport number")]
        public int internationlal_passport_num { get; set; }
    
        public virtual ICollection<baggage> baggage { get; set; }
        public virtual city city1 { get; set; }
        public virtual ICollection<ticket> ticket { get; set; }
    }
}