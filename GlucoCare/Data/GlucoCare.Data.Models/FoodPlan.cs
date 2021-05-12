namespace GlucoCare.Data.Models
{
    using System.Collections.Generic;

    using GlucoCare.Data.Common.Models;

    public class FoodPlan: BaseDeletableModel<int>
    {
        public FoodPlan()
        {
            this.Foods = new HashSet<Food>();
        }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Food> Foods { get; set; }
    }
}
