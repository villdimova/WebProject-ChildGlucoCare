namespace ChildGlucoCare.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ChildGlucoCare.Data.Common.Models;
    using ChildGlucoCare.Data.Models.Enums;

    public class Insulin : BaseDeletableModel<int>
    {
        public Insulin()
        {
            this.InsulinInjections = new HashSet<InsulinInjection>();
        }

        [Required]
        public InsulinType InsulinType { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Taken { get; set; }

        [Required]
        public string Onset { get; set; }

        [Required]
        public string Peak { get; set; }

        [Required]
        public string Duration { get; set; }

        public ICollection<InsulinInjection> InsulinInjections { get; set; }
    }
}
