namespace ChildGlucoCare.Web.ViewModels.Statistics
{
    using System.Collections.Generic;

    using ChildGlucoCare.Web.ViewModels.BloodGlucoses;
    using ChildGlucoCare.Web.ViewModels.CarbohydtrateIntakes;
    using ChildGlucoCare.Web.ViewModels.InsulinInjections;
    using ChildGlucoCare.Web.ViewModels.SportActivities;

    public class StatisticInfoViewModel
    {
        public IEnumerable<BloodGlucoseViewModel> YesterdayBloodGlucoses { get; set; }

        public IEnumerable<SportActivityViewModel> YesterdaySportActivities { get; set; }

        public IEnumerable<InsulinInjectionViewModel> YesterdayInsulinInjections { get; set; }
    }
}
