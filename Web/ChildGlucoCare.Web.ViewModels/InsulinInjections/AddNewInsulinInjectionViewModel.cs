namespace ChildGlucoCare.Web.ViewModels.InsulinInjections
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using ChildGlucoCare.Data.Models;

    public class AddNewInsulinInjectionViewModel
    {
        [Required]
        [Range(0, 99.9)]
        [Display(Name = "Insulin Dose")]
        public double InsulinDose { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Meal coverage")]
        public bool IsItForMeal { get; set; }

        [Required]
        [Display(Name = "Insulin")]
        public string InsulinName { get; set; }

        //[Required]
        //[MinLength(2)]
        //[MaxLength(15)]
        //[RegularExpression("^[A-Z]{1}[a-z0-9]+$")]
        public string UserName { get; set; }

    }
}
