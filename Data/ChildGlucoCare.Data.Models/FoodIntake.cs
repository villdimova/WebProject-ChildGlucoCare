namespace ChildGlucoCare.Data.Models
{
    using ChildGlucoCare.Data.Common.Models;

    public class FoodIntake : BaseDeletableModel<int>
    {
        public int FoodId { get; set; }

        public Food Food { get; set; }

        public string FoodName { get; set; }

        public int Amount { get; set; }

        public int? CarbohydrateIntakeId { get; set; }

        public CarbohydrateIntake CarbohydrateIntake { get; set; }
    }
}
