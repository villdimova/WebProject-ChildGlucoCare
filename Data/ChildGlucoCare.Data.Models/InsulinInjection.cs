namespace ChildGlucoCare.Data.Models
{
    using System;
    

    using ChildGlucoCare.Data.Common.Models;

    public class InsulinInjection: BaseDeletableModel<int>
    {
        public double InsulinDose { get; set; }

        public DateTime Hour { get; set; }

        public bool IsItForMeal { get; set; }

        public int InsulinId { get; set; }

        public Insulin Insulin { get; set; }

    }
}
