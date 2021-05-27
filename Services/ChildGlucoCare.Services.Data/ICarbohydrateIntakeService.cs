namespace ChildGlucoCare.Services.Data
{
    using System;
    using System.Threading.Tasks;
    using ChildGlucoCare.Web.ViewModels.CarbohydtrateIntakes;

    public interface ICarbohydrateIntakeService
    { 
        Task AddCarbohydrateIntakeAsync(AddNewCarbohydtrateIntakeViewModel carbohydrateIntake);

        double GetBeuFromCarbohydrate();

        string CalculateNeededInsulin(DateTime eatTime, double currentBloodGlucose, double insulinSensibility);

    }
}
