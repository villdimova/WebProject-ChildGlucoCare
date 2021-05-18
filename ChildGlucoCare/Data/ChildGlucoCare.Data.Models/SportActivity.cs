namespace ChildGlucoCare.Data.Models
{
    using System;
    using ChildGlucoCare.Data.Common.Models;
    using ChildGlucoCare.Data.Models.Enums;

    public class SportActivity: BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public ActivityLevel ActivityLevel { get; set; }

        public TimeSpan Duration { get; set; }

        public DateTime Hour { get; set; }

        public int DiabeticDiaryId { get; set; }

        public virtual DiabeticDiary DiabeticDiary { get; set; }
    }
}
