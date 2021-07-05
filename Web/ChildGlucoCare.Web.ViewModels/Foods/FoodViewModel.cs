namespace ChildGlucoCare.Web.ViewModels.Foods
{
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Mapping;

    public class FoodViewModel : IMapFrom<Food>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int GramsPerBreadUnit { get; set; }

        public int GlycemicIndex { get; set; }

        public int CarbohydratePer100Grams { get; set; }

        public double FatPer100Grams { get; set; }

        public int CaloriesPer100Grams { get; set; }

        public int? CarbohydrateIntakeId { get; set; }

        public string FoodType { get; set; }
    }
}
