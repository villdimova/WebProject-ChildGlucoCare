namespace ChildGlucoCare.Data.Models
{
    using System.Collections.Generic;
    using ChildGlucoCare.Data.Common.Models;
    using ChildGlucoCare.Data.Models.Enums;

    public class Sport: BaseDeletableModel<int>
    {
        public Sport()
        {
            this.SportActivities = new HashSet<SportActivity>();
        }

        public string SportName { get; set; }

        public ActivityLevel ActivityLevel { get; set; }

        public ICollection<SportActivity> SportActivities { get; set; }

    }
}
