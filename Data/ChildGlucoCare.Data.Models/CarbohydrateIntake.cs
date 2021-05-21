namespace ChildGlucoCare.Data.Models
{
    using System;
    using System.Collections.Generic;

    using ChildGlucoCare.Data.Common.Models;

    public class CarbohydrateIntake: BaseDeletableModel<int>
    {
        public CarbohydrateIntake()
        {
            this.Foods = new HashSet<Food>();
        }

        public string FoodName { get; set; }

        public int Amount { get; set; }

        public string  UserName { get; set; }

        public DateTime Date { get; set; }

        public virtual ICollection<Food> Foods { get; set; }

       
    }
}
