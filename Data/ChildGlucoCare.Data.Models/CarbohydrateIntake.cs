namespace ChildGlucoCare.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using ChildGlucoCare.Data.Common.Models;
    using ChildGlucoCare.Data.Models.Enums;

    public class CarbohydrateIntake : BaseDeletableModel<int>
    {
        public CarbohydrateIntake()
        {
            this.Foods = new HashSet<FoodIntake>();
        }

        public MealType MealType { get; set; }

        public DateTime Date { get; set; }

        public double TotalBeu { get; set; }

        public double TotalFat { get; set; }

        public double GlycemicLoad { get; set; }

        public double SuggestedDoseInsulin { get; set; }

        public virtual ICollection<FoodIntake> Foods { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
