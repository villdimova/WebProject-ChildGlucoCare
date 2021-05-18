namespace ChildGlucoCare.Data.Models
{
    using System;

    using ChildGlucoCare.Data.Common.Models;
  
    public class InjectedInsulin: BaseDeletableModel<int>
    {
        public int InsulinId { get; set; }

        public Insulin Insulin { get; set; }

        public int InsulinDose { get; set; }

        public TimeSpan InjectionTimeBeforeEating { get; set; }

        public  DateTime Hour { get; set; }

        public decimal InsulinRatio { get; set; }

        public int DiabeticDiaryId { get; set; }

        public virtual DiabeticDiary DiabeticDiary { get; set; }

    }
}