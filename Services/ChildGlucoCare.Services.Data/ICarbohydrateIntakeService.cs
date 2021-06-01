namespace ChildGlucoCare.Services.Data
{
    using System;
    using System.Threading.Tasks;
    using ChildGlucoCare.Web.ViewModels.CarbohydtrateIntakes;
    using ChildGlucoCare.Services.Mapping;
    using ChildGlucoCare.Data.Models;
    using System.Collections.Generic;

    public interface ICarbohydrateIntakeService
    { 
        Task AddCarbohydrateIntakeAsync(AddNewCarbohydtrateIntakeViewModel carbohydrateIntake);

        IEnumerable<T> GetAllBeu<T>();

        CarbohydrateIntake LastAddedCarbs();

    }
}
