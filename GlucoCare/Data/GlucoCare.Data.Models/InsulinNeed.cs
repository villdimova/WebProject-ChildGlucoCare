namespace GlucoCare.Data.Models
{
    using System;

    using System.ComponentModel.DataAnnotations.Schema;

    using GlucoCare.Data.Common.Models;

    public class InsulinNeed: BaseDeletableModel<int>
    {
        public int InsulinDose { get; set; }

        public TimeSpan InjectionTimeBeforeEating { get; set; }

        public int DayPartId { get; set; }

        public virtual DayPart DayPart { get; set; }

        public virtual CarbohydrateIntake CarbohidrateIntake { get; set; }

        public int? CarbohidrateIntakeId { get; set; }

        [ForeignKey(nameof(SportActivity))]
        public int SportActivityId { get; set; }

        public virtual SportActivity SportActivity { get; set; }

        [ForeignKey(nameof(BloodGlucose))]
        public int BloodGlucoseId { get; set; }

        public virtual BloodGlucose BloodGlucose { get; set; }

    }
}