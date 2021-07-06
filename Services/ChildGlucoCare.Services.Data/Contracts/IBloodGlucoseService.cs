namespace ChildGlucoCare.Services.Data.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Web.ViewModels.BloodGlucoses;

    public interface IBloodGlucoseService
    {
        Task AddBloodGlucoseAsync(AddBloodGlucoseInputModel bloodGlucoseViewModel, ApplicationUser user);

        double CalculateProperInsulinDose(BloodGlucoseInputModel bloodGlucoseViewModel, ApplicationUser user);

        BloodGlucose LastAddedBloodGlucose();

        Task<T> GetBloodGlucoseAsync<T>(int bloodGlucoseId);

        Task<BloodGlucose> DeleteBloodGlucoseAsync(int bloodGlucoseId);

        Task<BloodGlucose> EditBloodGlucoseAsync(EditBloodGlucoseInputModel inputModel, ApplicationUser user);

        Task<IEnumerable<T>> GetAll<T>();
    }
}
