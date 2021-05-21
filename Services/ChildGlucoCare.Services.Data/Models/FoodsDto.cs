namespace ChildGlucoCare.Services.Data.Models
{
    using ChildGlucoCare.Data.Models.Enums;

    public class FoodsDto
    {

        public string Name { get; set; }

        public int GramsPerBreadUnit { get; set; }

        public int GlycemicIndex { get; set; }

        public int CarbohydratePer100Grams { get; set; }

        public double FatPer100Grams { get; set; }

        public int CaloriesPer100Grams { get; set; }

        public int? CarbohydrateIntakeId { get; set; }

        public FoodType FoodType { get; set; }

    }
}
