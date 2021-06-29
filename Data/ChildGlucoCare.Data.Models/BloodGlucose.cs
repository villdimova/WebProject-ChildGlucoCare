namespace ChildGlucoCare.Data.Models
{
    using System;

    using ChildGlucoCare.Data.Common.Models;
    using ChildGlucoCare.Data.Models.Enums;

    public class BloodGlucose : BaseDeletableModel<int>
    {
        public double CurrentGlucoseLevel { get; set; }

        public DateTime Date { get; set; }

        public BloodGlocoseStatus BloodGlocoseStatus { get; set; }

        public double SuggestedCorrectionDoseInsulin { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
