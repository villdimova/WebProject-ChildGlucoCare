namespace ChildGlucoCare.Web.ViewModels.InsulinInjections
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static ChildGlucoCare.Data.Common.DataConstants;

    public class AddNewInsulinInjectionViewModel
    {
        [Required]
        [Range(MinInsulinInjection, MaxInsulinInjection)]
        [Display(Name = "Insulin Dose")]
        public double InsulinDose { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        [Required]
        [Range(MinBloodGlucoseLevel, MaxBloodGlucoseLevel)]
        [Display(Name = "Current Glucose Level")]
        public double CurrentGlucoseLevel { get; set; }

        [Required]
        [Range(MinTotalBeu, MaxTotalBeu)]
        public double TotalBeu { get; set; }

        [Required]
        [Display(Name = "Insulin")]
        public string InsulinName { get; set; }
    }
}
