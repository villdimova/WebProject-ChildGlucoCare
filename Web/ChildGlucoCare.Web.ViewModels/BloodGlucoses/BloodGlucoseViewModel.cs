namespace ChildGlucoCare.Web.ViewModels.BloodGlucoses
{
    using System;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Data.Models.Enums;
    using ChildGlucoCare.Services.Mapping;

    public class BloodGlucoseViewModel : IMapFrom<BloodGlucose>
    {
        public double CurrentGlucoseLevel { get; set; }

        public DateTime Date { get; set; }

        public BloodGlocoseStatus BloodGlocoseStatus { get; set; }
    }
}
