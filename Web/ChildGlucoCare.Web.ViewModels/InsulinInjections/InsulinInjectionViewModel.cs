namespace ChildGlucoCare.Web.ViewModels.InsulinInjections
{
    using System;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Mapping;

    public class InsulinInjectionViewModel : IMapFrom<InsulinInjection>
    {
        public int Id { get; set; }

        public double InsulinDose { get; set; }

        public DateTime Date { get; set; }

        public double CurrentGlucoselevel { get; set; }

        public double TotalMealBeu { get; set; }
    }
}
