namespace GlucoCare.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    using GlucoCare.Data.Common.Models;

    public class BloodGlucose: BaseDeletableModel<int>
    {
        public decimal CurrentGlucoseLevel { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser Diabetic { get; set; }

        [ForeignKey(nameof(InsulinNeed))]
        public int InsulinNeedId { get; set; }

        public virtual InsulinNeed InsulinNeed { get; set; }
    }
}