namespace ChildGlucoCare.Web.ViewModels.CarbohydtrateIntakes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Data.Models.Enums;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class AddNewCarbohydtrateIntakeViewModel
    {
        public AddNewCarbohydtrateIntakeViewModel()
        {
            this.Foods = new HashSet<FoodIntake>();
            this.FoodNames = new List<SelectListItem>();
        }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        [Required]
        [EnumDataType(typeof(MealType))]
        [Display(Name = "Meal Category")]
        public MealType MealType { get; set; }

        [Required]
        [Range(1.0, 30.0)]
        [Display(Name = "Current Glucose Level")]
        public double CurrentGlucoseLevel { get; set; }

        public ICollection<FoodIntake> Foods { get; set; }

        public IEnumerable<SelectListItem> FoodNames { get; set; }
    }
}
