namespace ChildGlucoCare.Web.ViewModels.Statistics
{
    using System.Collections.Generic;

    using ChildGlucoCare.Web.ViewModels.InsulinInjections;
    using ChildGlucoCare.Web.ViewModels.SportActivities;

    public class StatisticInfoViewModel
    {
        public IEnumerable<BloodGlucoses.BloodGlucoseViewModel> BloodGlucoses { get; set; }

        public IEnumerable<SportActivityViewModel> SportActivities { get; set; }

        public IEnumerable<InsulinInjectionViewModel>InsulinInjections { get; set; }
    }
}
