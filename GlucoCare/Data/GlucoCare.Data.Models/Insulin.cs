namespace GlucoCare.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using GlucoCare.Data.Common.Models;

    public class Insulin: BaseDeletableModel<int>
    {
        [Required]
        public string InsulinType { get; set; }

        [Required]
        public string Name { get; set; }

        public string UserId { get; set; }

        public virtual ApplicationUser Diabetic { get; set; }
    }
}
