namespace ChildGlucoCare.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using ChildGlucoCare.Data.Common.Models;

    public class SportActivity : BaseDeletableModel<int>
    {
        [Required]
        public string SportName { get; set; }

        [Required]
        public string ActivityLevel { get; set; }

        public int Duration { get; set; }

        public DateTime Date { get; set; }

        public Sport Sport { get; set; }

        public int SportId { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
