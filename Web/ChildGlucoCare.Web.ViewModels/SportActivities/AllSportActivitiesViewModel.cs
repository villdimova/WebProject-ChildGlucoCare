namespace ChildGlucoCare.Web.ViewModels.SportActivities
{
    using System.Collections.Generic;

    public class AllSportActivitiesViewModel
    {
        public AllSportActivitiesViewModel()
        {
            this.SportActivities = new HashSet<SportActivityViewModel>();
        }

        public IEnumerable<SportActivityViewModel> SportActivities { get; set; }
    }
}
