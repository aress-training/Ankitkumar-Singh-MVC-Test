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

    public partial class AppointmentDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AppointmentDetail()
        {
            this.TreatmentDetails = new HashSet<TreatmentDetail>();
        }

        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        [Required(ErrorMessage = "Count cannot be empty enter in between(0,110)")]
        [Range(0, 110)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please enter disease deatils")]
        public string DiseaseInfo { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Appointment Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime AppointmentDate { get; set; }
        public string AppointmentTime { get; set; }
        public bool SheduleUpdated { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime SheduleDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TreatmentDetail> TreatmentDetails { get; set; }
        public virtual PatientDetail PatientDetail { get; set; }
    }
}
