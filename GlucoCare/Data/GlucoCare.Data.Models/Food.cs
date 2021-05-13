namespace GlucoCare.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using GlucoCare.Data.Common.Models;
    using GlucoCare.Data.Models.Enums;

    public class Food: BaseDeletableModel<int>
    {

        [Range(0, 100)]
        public int Grams { get; set; }

        public int GlycemicIndex { get; set; }

        public double CarbohydratePer100Grams { get; set; }

        [Range(0, 100)]
        public double FatPer100Grams { get; set; }

        [Range(0, 100)]
        public double WaterPer100Grams { get; set; }

        [Range(0, 100)]
        public double ProteinPer100Grams { get; set; }

        [Range(0, 4000)]
        public double CaloriesPer100Grams { get; set; }

        public int CarbohidrateIntakeId { get; set; }

        public virtual CarbohydrateIntake CarbohidrateIntake { get; set; }

        public FoodType FoodType { get; set; }

        public int FoodPlanId { get; set; }

        public virtual FoodPlan FoodPlan { get; set; }

        public string FoodImageUrl { get; set; }

    }
}
