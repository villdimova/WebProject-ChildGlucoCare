namespace ChildGlucoCare.Web.ViewModels.BloodGlucoses
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using ChildGlucoCare.Data.Models.Enums;
    using ChildGlucoCare.Web.ViewModels.ValidationAttributes;

    public class AddBloodGlucoseViewModel
    {
        private DateTime? dateCreated = null;

        [Required]
        [Range(1.0, 30.0)]
        [Display(Name = "Current Glucose Level")]
        public double CurrentGlucoseLevel { get; set; }

        [DateValidation(2020)]
        public DateTime Date { get; set; }


        [Required]
        [Range(1.0, 30.0)]
        [Display(Name = "Write your Insulin Sensitvity Factor")]
        public double InsulinSensitivity { get; set; }

    }
}
