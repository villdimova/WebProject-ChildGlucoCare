namespace ChildGlucoCare.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using ChildGlucoCare.Data.Common.Models;

    public class StatisticPeriod: BaseDeletableModel<int>
    {
        [Required]
        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public int Days { get; set; }
    }
}
