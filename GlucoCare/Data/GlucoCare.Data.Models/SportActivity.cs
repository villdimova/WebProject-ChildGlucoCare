namespace GlucoCare.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    using GlucoCare.Data.Common.Models;

    public class SportActivity: BaseDeletableModel<int>
    {
        public string ActivityLevel { get; set; }

        [ForeignKey(nameof(InsulinNeed))]
        public int InsulinNeedId { get; set; }

        public InsulinNeed InsulinNeed { get; set; }
    }
}
