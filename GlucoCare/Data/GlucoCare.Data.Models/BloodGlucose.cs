namespace GlucoCare.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    using GlucoCare.Data.Common.Models;
    using GlucoCare.Data.Models.Enums;

    public class BloodGlucose: BaseDeletableModel<int>
    {
        public decimal CurrentGlucoseLevel { get; set; }

        public DateTime Date { get; set; }

        public BloodGlocoseStatus BloodGlocoseStatus { get; set; }

        public int? InjectedInsulinId { get; set; }

        public virtual InjectedInsulin InjectedInsulin { get; set; }

        public int BloodGlucosesRecodId { get; set; }

        public virtual BloodGlucosesRecord BloodGlucosesRecord { get; set; }
    }
}