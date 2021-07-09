namespace ChildGlucoCare.Web.ViewModels.Foods
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ChildGlucoCare.Data.Models.Enums;

    using static ChildGlucoCare.Data.Common.DataConstants;

    public class CreateFoodInputModel
    {
        [Required]
        [MinLength(MinFoodNameLength)]
        [MaxLength(MaxFoodNameLength)]
        public string Name { get; set; }

        [Range(MinFoodGrams, MaxFoodGrams)]
        [Required]
        [Display(Name = "Grams Per One Bread Unit")]
        public int GramsPerBreadUnit { get; set; }

        [Range(MinFoodGrams, MaxFoodGrams)]
        [Required]
        [Display(Name = "Glycemic Index")]
        public int GlycemicIndex { get; set; }

        [Range(MinFoodGrams, MaxFoodGrams)]
        [Required]
        [Display(Name = "Carbohydrate Per 100 Grams")]
        public int CarbohydratePer100Grams { get; set; }

        [Range(MinFoodGrams, MaxFoodGrams)]
        [Required]
        [Display(Name = "Fat Per 100 Grams")]
        public double FatPer100Grams { get; set; }

        [Range(MinCaloriesPer100Grams, MaxCaloriesPer100Grams)]
        [Required]
        [Display(Name = "Calories Per 100 Grams")]
        public int CaloriesPer100Grams { get; set; }

        public int? CarbohydrateIntakeId { get; set; }

        [Required]
        [EnumDataType(typeof(FoodType))]
        [Display(Name = "Food Category")]
        public FoodType FoodType { get; set; }
    }
}
