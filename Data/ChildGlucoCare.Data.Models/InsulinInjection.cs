namespace ChildGlucoCare.Data.Models
{
    using System;

    using ChildGlucoCare.Data.Common.Models;

    public class InsulinInjection: BaseDeletableModel<int>
    {
        public double InsulinDose { get; set; }

        public DateTime Date { get; set; }

        public bool IsItForMeal { get; set; }

        public string UserName { get; set; }

        public int InsulinId { get; set; }

        public virtual Insulin Insulin { get; set; }

        public int UserDashboardId { get; set; }

        public virtual UserDashboard UserDashboard { get; set; }

    }
}
