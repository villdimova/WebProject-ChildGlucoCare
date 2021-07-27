namespace ChildGlucoCare.Web.ViewModels.Home
{
    using ChildGlucoCare.Web.ViewModels.BloodGlucoses;
    using ChildGlucoCare.Web.ViewModels.CarbohydtrateIntakes;
    using ChildGlucoCare.Web.ViewModels.InsulinInjections;
    using ChildGlucoCare.Web.ViewModels.SportActivities;
    using ChildGlucoCare.Web.ViewModels.Statistics;

    public class UserDashboardViewModel
    {
        public BloodGlucoseViewModel LastBloodGlucose { get; set; }

        public SportActivityViewModel LastSportActivitie { get; set; }

        public CarbsViewModel LastMeal { get; set; }

        public InsulinInjectionViewModel LastInjection { get; set; }

        public BloodGlucoseReportViewModel BloodGlucoseReport { get; set; }
    }
}
