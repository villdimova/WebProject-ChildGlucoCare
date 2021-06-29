namespace ChildGlucoCare.Web.ViewModels.BloodGlucoses
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class AddBloodGlucoseViewModel
    {
        [Required]
        [Range((double)1.0, 30.0)]
        [Display(Name = "Current Glucose Level")]
        public double CurrentGlucoseLevel { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        [Required]
        [Range(1.0, 30.0)]
        [Display(Name = "Write your Insulin Sensitvity Factor")]
        public double InsulinSensitivity { get; set; }
    }
}
