namespace ChildGlucoCare.Services.Data.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Web.ViewModels.CarbohydtrateIntakes;

    public interface ICarbohydrateIntakeService
    {
        Task AddCarbohydrateIntakeAsync(AddNewCarbohydtrateIntakeViewModel carbohydrateIntake,string userId);

        IEnumerable<T> GetAllBeu<T>();

        CarbohydrateIntake LastAddedCarbs();

        double CalculateProperInsulinDose(AddNewCarbohydtrateIntakeViewModel carbohydrateIntake, double totalBeu,double insulinSensitivity);

    }
}
