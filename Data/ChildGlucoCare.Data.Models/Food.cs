namespace ChildGlucoCare.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ChildGlucoCare.Data.Common.Models;
    using ChildGlucoCare.Data.Models.Enums;

    public class Food: BaseDeletableModel<int>
    {

        [Required]
        public string Name { get; set; }

        [Range(0, 100)]
        public int GramsPerBreadUnit { get; set; }

        public int GlycemicIndex { get; set; }

        public int CarbohydratePer100Grams { get; set; }

        [Range(0, 100)]
        public double FatPer100Grams { get; set; }

        [Range(0, 4000)]
        public int CaloriesPer100Grams { get; set; }

        public int FoodCarbohydrateIntakeId { get; set; }

        public int? CarbohydrateIntakeId { get; set; }

        public CarbohydrateIntake CarbohydrateIntake { get; set; }

        public virtual FoodType FoodType { get; set; }


    }
}
