namespace ChildGlucoCare.Web.ViewModels.Foods
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ChildGlucoCare.Data.Models.Enums;

  public class CreateFoodInputModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }

        [Range(0, 100)]
        [Required]
        [Display(Name = "Grams Per One Bread Unit")]
        public int GramsPerBreadUnit { get; set; }

        [Range(0,100)]
        [Required]
        [Display(Name = "Glycemic Index")]
        public int GlycemicIndex { get; set; }

        [Range(0, 100)]
        [Required]
        [Display(Name = "Carbohydrate Per 100 Grams")]
        public int CarbohydratePer100Grams { get; set; }

        [Range(0, 100)]
        [Required]
        [Display(Name = "Fat Per 100 Grams")]
        public double FatPer100Grams { get; set; }

        [Range(0, 4000)]
        [Required]
        [Display(Name = "Calories Per 100 Grams")]
        public int CaloriesPer100Grams { get; set; }

        public int? CarbohydrateIntakeId { get; set; }

        [Required]
        [EnumDataType(typeof(FoodType))]
        [Display(Name = "Food Category")]
        public FoodType FoodType { get; set; }

        [Display(Name = "Image")]
        public string FoodImageUrl { get; set; }

    }
}
