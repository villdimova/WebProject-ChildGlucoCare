namespace ChildGlucoCare.Data.Models
{
    using ChildGlucoCare.Data.Common.Models;
    using System.ComponentModel.DataAnnotations;

    public class FoodIntake : BaseDeletableModel<int>
    {
        public int FoodId { get; set; }

        public Food Food { get; set; }

        [Required]
        public string FoodName { get; set; }

        public int Amount { get; set; }

        public int? CarbohydrateIntakeId { get; set; }

        public CarbohydrateIntake CarbohydrateIntake { get; set; }
    }
}
