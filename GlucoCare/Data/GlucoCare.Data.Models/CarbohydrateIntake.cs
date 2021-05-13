namespace GlucoCare.Data.Models
{
    using System;
    using System.Collections.Generic;

    using System.ComponentModel.DataAnnotations.Schema;

    using GlucoCare.Data.Common.Models;

    public class CarbohydrateIntake: BaseDeletableModel<int>
    {
        public CarbohydrateIntake()
        {
            this.Foods = new HashSet<Food>();
            this.Insulins = new HashSet<CarbohydrateIntakeInjectedInsulin>();
        }

        public DateTime Date { get; set; }

        public int Amount { get; set; }

        public virtual ICollection<Food> Foods { get; set; }

        public int CarbohydrateIntakesRecordId { get; set; }

        public virtual CarbohydrateIntakesRecord CarbohydrateIntakesRecord { get; set; }

        public virtual ICollection<CarbohydrateIntakeInjectedInsulin> Insulins { get; set; }
    }
}
