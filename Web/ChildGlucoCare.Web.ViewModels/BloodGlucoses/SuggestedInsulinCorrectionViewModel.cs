namespace ChildGlucoCare.Web.ViewModels.BloodGlucoses
{
    using System;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Mapping;

    public class SuggestedInsulinCorrectionViewModel: IMapFrom<BloodGlucose>
    {
        public double CurrentGlucoseLevel { get; set; }

        public DateTime Date { get; set; }

        public double SuggestedCorrectionDoseInsulin { get; set; }
    }
}
