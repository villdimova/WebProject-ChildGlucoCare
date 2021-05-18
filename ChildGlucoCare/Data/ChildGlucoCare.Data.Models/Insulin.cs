namespace ChildGlucoCare.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using ChildGlucoCare.Data.Common.Models;
    using ChildGlucoCare.Data.Models.Enums;

    public class Insulin: BaseDeletableModel<int>
    {
        [Required]
        public InsulinType InsulinType { get; set; }

        [Required]
        public string Name { get; set; }

        public string InsulinActionUrl { get; set; }

    }
}
