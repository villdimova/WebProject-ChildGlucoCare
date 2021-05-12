namespace GlucoCare.Data.Models
{
    using System.Collections.Generic;

    using System.ComponentModel.DataAnnotations.Schema;

    using GlucoCare.Data.Common.Models;

    public class CarbohydrateIntake: BaseDeletableModel<int>
    {
        public CarbohydrateIntake()
        {
            this.Foods = new HashSet<Food>();
        }

        public string UserId { get; set; }

        public virtual ApplicationUser Diabetic { get; set; }

        public int Amount { get; set; }

        [ForeignKey(nameof(InsulinNeed))]
        public int InsulinNeedId { get; set; }

        public virtual InsulinNeed InsulinNeed { get; set; }

        public virtual ICollection<Food> Foods { get; set; }
    }
}
