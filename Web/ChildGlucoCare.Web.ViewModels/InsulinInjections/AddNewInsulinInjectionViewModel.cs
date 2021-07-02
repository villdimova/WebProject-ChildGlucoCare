namespace ChildGlucoCare.Web.ViewModels.InsulinInjections
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class AddNewInsulinInjectionViewModel
    {
        [Required]
        [Range(0, 99.9)]
        [Display(Name = "Insulin Dose")]
        public double InsulinDose { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        [Required]
        [Range(1.0, 30.0)]
        [Display(Name = "Current Glucose Level")]
        public double CurrentGlucoseLevel { get; set; }

        [Required]
        [Range(0.1, 20.0)]
        public double TotalBeu { get; set; }

        [Required]
        [Display(Name = "Insulin")]
        public string InsulinName { get; set; }
    }
}
