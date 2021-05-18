namespace ChildGlucoCare.Data.Models
{
    using System;

    using ChildGlucoCare.Data.Common.Models;
    using ChildGlucoCare.Data.Models.Enums;

    public class BloodGlucose: BaseDeletableModel<int>
    {
        public decimal CurrentGlucoseLevel { get; set; }

        public DateTime Date { get; set; }

        public BloodGlocoseStatus BloodGlocoseStatus { get; set; }

        public int DiabeticDiaryId { get; set; }

        public virtual DiabeticDiary DiabeticDiary { get; set; }
    }
}