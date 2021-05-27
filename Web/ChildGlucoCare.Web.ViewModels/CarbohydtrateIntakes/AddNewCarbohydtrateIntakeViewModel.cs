﻿namespace ChildGlucoCare.Web.ViewModels.CarbohydtrateIntakes
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Data.Models.Enums;
    using ChildGlucoCare.Web.ViewModels.Foods;

    public class AddNewCarbohydtrateIntakeViewModel
    {
        public AddNewCarbohydtrateIntakeViewModel()
        {
            this.Foods = new HashSet<FoodIntake>();
        }

        [Required]
        public DateTime Date { get; set; }

        //[Range(0, 1000)]
        //[Display(Name = "Amount in grams")]
        //public int Amount { get; set; }

        //[Required]
        //[MinLength(3)]
        //[MaxLength(30)]
        //public string FoodName { get; set; }

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

    }
}
