namespace ChildGlucoCare.Web.ViewModels.CarbohydtrateIntakes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Data.Models.Enums;
    using ChildGlucoCare.Web.ViewModels.Foods;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class AddNewCarbohydtrateIntakeViewModel
    {
        public AddNewCarbohydtrateIntakeViewModel()
        {
            this.Foods = new HashSet<FoodIntake>();
            this.FoodNames = new List<SelectListItem>();
        }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        //[Required]
        //[MinLength(2)]
        //[MaxLength(15)]
        //[RegularExpression("^[A-Z]{1}[a-z0-9]+$")]
        public string AddedByUser { get; set; }

        [Required]
        [EnumDataType(typeof(MealType))]
        [Display(Name = "Meal Category")]
        public MealType MealType { get; set; }

        public ICollection<FoodIntake> Foods { get; set; }

        public IEnumerable<SelectListItem> FoodNames { get; set; }

    }
}
