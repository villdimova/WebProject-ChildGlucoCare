namespace GlucoCare.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using GlucoCare.Data.Common.Models;
    using GlucoCare.Data.Models.Enums;

    public class Insulin: BaseDeletableModel<int>
    {
        [Required]
        public InsulinType InsulinType { get; set; }

        [Required]
        public string Name { get; set; }

        public string InsulinActionUrl { get; set; }

    }
}
