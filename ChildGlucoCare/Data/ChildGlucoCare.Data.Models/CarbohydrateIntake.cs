namespace ChildGlucoCare.Data.Models
{
    using System;
    using System.Collections.Generic;

    using ChildGlucoCare.Data.Common.Models;

    public class CarbohydrateIntake: BaseDeletableModel<int>
    {
        public CarbohydrateIntake()
        {
            this.Foods = new HashSet<FoodCarbohydrateIntake>();
        }

        public DateTime Date { get; set; }

        public int Amount { get; set; }

        public int NeededInsulin { get; set; }

        public int DiabeticDiaryId { get; set; }

        public virtual DiabeticDiary DiabeticDiary { get; set; }

        public virtual ICollection<FoodCarbohydrateIntake> Foods { get; set; }

    }
}
