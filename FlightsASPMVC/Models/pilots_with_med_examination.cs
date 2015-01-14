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
    
    public partial class pilots_with_med_examination
    {
        [Display(Name = "Pilot identifier")]
        public int id { get; set; }

        [Display(Name = "Name")]
        public string name { get; set; }

        [Display(Name = "Lastname")]
        public string lastname { get; set; }

        [Display(Name = "Patronymic")]
        public string patronymic { get; set; }

        [Display(Name = "Phone")]
        public string phone { get; set; }

        [Display(Name = "Additional phone")]
        public string additional_phone { get; set; }

        [Display(Name = "Comment")]
        public string comment { get; set; }

        [Display(Name = "Number of flights")]
        public Nullable<int> number_of_flights { get; set; }

        [Display(Name = "Hours in flights")]
        public Nullable<int> hours_in_flights { get; set; }

        [Display(Name = "Hire date")]
        public System.DateTime hire_date { get; set; }

        [Display(Name = "Date of dismissal")]
        public Nullable<System.DateTime> date_of_dismissal { get; set; }

        [Display(Name = "City of residence")]
        public int city_of_residence { get; set; }

        [Display(Name = "Type")]
        public int type { get; set; }

        [Display(Name = "Last medical examination")]
        public System.DateTime last_medical_examination { get; set; }

        [Display(Name = "Brigade")]
        public int brigade { get; set; }

        [Display(Name = "Airport")]
        public int airport { get; set; }

        [Display(Name = "Salary")]
        public int salary { get; set; }

        [Display(Name = "Children count")]
        public Nullable<int> childrencount { get; set; }

        [Display(Name = "Sex")]
        public string sex { get; set; }
    }
}