namespace ChildGlucoCare.Data.Models
{
    using ChildGlucoCare.Data.Common.Models;
    using System;

    public class SportActivity:BaseDeletableModel<int>
    {
        public string SportName { get; set; }

        public string ActivityLevel { get; set; }

        public int Duration { get; set; }

        public DateTime Date { get; set; }

        public string UserName { get; set; }

        public Sport Sport { get; set; }

        public int SportId { get; set; }

   //     public int UserDashboardId { get; set; }

  //      public virtual UserDashboard UserDashboard { get; set; }

    }
}
