namespace ChildGlucoCare.Data.Models
{
    using System;
    using System.Collections.Generic;

    using ChildGlucoCare.Data.Common.Models;
    using ChildGlucoCare.Data.Models.Enums;

    public class CarbohydrateIntake: BaseDeletableModel<int>
    {
        public CarbohydrateIntake()
        {
            this.Foods = new HashSet<FoodIntake>();
        }

        public MealType MealType { get; set; }

        public DateTime Date { get; set; }

        public double TotalBeu { get; set; }

        public double SuggestedDoseInsulin { get; set; }

        public virtual ICollection<FoodIntake> Foods { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
