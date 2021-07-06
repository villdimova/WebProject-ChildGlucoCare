namespace ChildGlucoCare.Web.ViewModels.CarbohydtrateIntakes
{
    using System;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Data.Models.Enums;
    using ChildGlucoCare.Services.Mapping;

    public class CarbsViewModel : IMapFrom<CarbohydrateIntake>
    {
        public int Id { get; set; }

        public MealType MealType { get; set; }

        public string UserName { get; set; }

        public DateTime Date { get; set; }

        public double? TotalBeu { get; set; }

        public double SuggestedDoseInsulin { get; set; }
    }
}
