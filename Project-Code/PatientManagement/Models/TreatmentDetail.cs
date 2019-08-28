//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PatientManagement.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TreatmentDetail
    {
        public int PatientId { get; set; }
        public System.DateTime TreatmentDate { get; set; }
        [Required(ErrorMessage = "Please enter treatment deatils")]
        public string Treatment { get; set; }
        [Required(ErrorMessage = "Please enter bill deatils")]
        public int Bill { get; set; }
        public int TreatmentId { get; set; }
        public Nullable<int> AppointmentId { get; set; }

        public virtual AppointmentDetail AppointmentDetail { get; set; }
        public virtual PatientDetail PatientDetail { get; set; }
    }
}
