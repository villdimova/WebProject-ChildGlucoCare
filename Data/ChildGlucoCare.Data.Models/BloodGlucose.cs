namespace ChildGlucoCare.Data.Models
{
    using System;
    using ChildGlucoCare.Data.Common.Models;
    using ChildGlucoCare.Data.Models.Enums;

    public class BloodGlucose: BaseDeletableModel<int>
    {
        public decimal CurrentGlucoseLevel { get; set; }

        public DateTime Date { get; set; }

        public BloodGlocoseStatus BloodGlocoseStatus { get; set; }

     //   public int UserDashboardId { get; set; }

    //    public virtual UserDashboard UserDashboard{ get; set; }

    }
}
