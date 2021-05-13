namespace GlucoCare.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using GlucoCare.Data.Common.Models;

    public class InjectedInsulin: BaseDeletableModel<int>
    {
        public InjectedInsulin()
        {
            this.CarbohydrateIntakes = new HashSet<CarbohydrateIntakeInjectedInsulin>();
        }
        public int InsulinId { get; set; }

        public Insulin Insulin { get; set; }

        public int InsulinDose { get; set; }

        public TimeSpan InjectionTimeBeforeEating { get; set; }

        public  DateTime Hour { get; set; }

        public decimal InsulinRatio { get; set; }

        [ForeignKey(nameof(SportActivity))]
        public int SportActivityId { get; set; }

        public virtual SportActivity SportActivity { get; set; }

        [ForeignKey(nameof(BloodGlucose))]
        public int BloodGlucoseId { get; set; }

        public virtual BloodGlucose BloodGlucose { get; set; }

        public ICollection<CarbohydrateIntakeInjectedInsulin> CarbohydrateIntakes { get; set; }

    }
}