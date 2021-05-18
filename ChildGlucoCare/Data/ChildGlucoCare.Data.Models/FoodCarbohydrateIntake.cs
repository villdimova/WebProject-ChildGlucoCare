namespace ChildGlucoCare.Data.Models
{

    public class FoodCarbohydrateIntake
    {
        public int FoodId { get; set; }

        public virtual Food Food { get; set; }

        public int? CarbohydrateIntakeId { get; set; }

        public CarbohydrateIntake CarbohydrateIntake { get; set; }
    }
}
