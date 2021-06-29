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

        public string Taken { get; set; }

        public string Onset { get; set; }

        public string Peak { get; set; }

        public string Duration { get; set; }

        public ICollection<InsulinInjection> InsulinInjections { get; set; }
    }
}
