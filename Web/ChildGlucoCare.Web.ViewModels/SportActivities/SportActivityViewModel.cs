namespace ChildGlucoCare.Web.ViewModels.SportActivities
{
    using System;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Mapping;

    public class SportActivityViewModel : IMapFrom<SportActivity>
    {
        public string SportName { get; set; }

        public string ActivityLevel { get; set; }

        public int Duration { get; set; }

        public DateTime Date { get; set; }

    }
}
