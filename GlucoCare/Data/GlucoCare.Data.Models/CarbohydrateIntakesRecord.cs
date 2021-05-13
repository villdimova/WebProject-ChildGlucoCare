namespace GlucoCare.Data.Models
{
    using System.Collections.Generic;

    using GlucoCare.Data.Common.Models;

    public class CarbohydrateIntakesRecord: BaseDeletableModel<int>
    {
        public CarbohydrateIntakesRecord()
        {
            this.CarbohydrateIntakes = new HashSet<CarbohydrateIntake>();
        }
        public virtual ApplicationUser Diabetic { get; set; }

        public string UserId { get; set; }

        public virtual ICollection<CarbohydrateIntake> CarbohydrateIntakes { get; set; }

    }
}
