namespace GlucoCare.Data.Models
{
    using System.Collections.Generic;

    using System.ComponentModel.DataAnnotations;

    using GlucoCare.Data.Common.Models;

    public class DayPart : BaseDeletableModel<int>
    {
        [Required]
        public string Name { get; set; }

        public decimal InsulinNeedRatio { get; set; }

        public virtual ICollection<InsulinNeed> InsulinNeeds { get; set; }
    }
}