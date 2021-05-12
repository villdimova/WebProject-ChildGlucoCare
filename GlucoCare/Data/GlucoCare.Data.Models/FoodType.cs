namespace GlucoCare.Data.Models
{
    using System.Collections.Generic;
   
    using GlucoCare.Data.Common.Models;

    public class FoodType: BaseDeletableModel<int>
    {

        public FoodType()
        {
            this.Foods = new HashSet<Food>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Food> Foods { get; set; }
    }
}
