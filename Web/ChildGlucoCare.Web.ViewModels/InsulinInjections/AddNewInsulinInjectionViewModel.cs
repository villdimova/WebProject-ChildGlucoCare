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
        [Display(Name = "Meal coverage")]
        public bool IsItForMeal { get; set; }

        [Required]
        [Display(Name = "Insulin")]
        public string InsulinName { get; set; }
    }
}
