namespace ChildGlucoCare.Services.Data.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Web.ViewModels.BloodGlucoses;

    public interface IBloodGlucoseService
    {
        Task AddBloodGlucoseAsync(AddBloodGlucoseViewModel bloodGlucoseViewModel, string userId);

        double CalculateProperInsulinDose(AddBloodGlucoseViewModel bloodGlucoseViewModel);

        BloodGlucose LastAddedBloodGlucose();

        IEnumerable<T> GetAll<T>();
    }
}
