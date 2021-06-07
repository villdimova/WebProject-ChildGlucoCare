namespace ChildGlucoCare.Services.Data
{
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Web.ViewModels.BloodGlucoses;

    public interface IBloodGlucoseService
    {
        Task AddBloodGlucoseAsync(AddBloodGlucoseViewModel bloodGlucoseViewModel);

        double CalculateProperInsulinDose(AddBloodGlucoseViewModel bloodGlucoseViewModel);

        BloodGlucose LastAddedBloodGlucose();
    }
}
