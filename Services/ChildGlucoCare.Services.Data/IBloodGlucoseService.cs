using ChildGlucoCare.Data.Models;
using ChildGlucoCare.Web.ViewModels.BloodGlucoses;
using System.Threading.Tasks;

namespace ChildGlucoCare.Services.Data
{
    public interface IBloodGlucoseService
    {
        Task AddBloodGlucoseAsync(AddBloodGlucoseViewModel bloodGlucoseViewModel);

        double CalculateProperInsulinDose(AddBloodGlucoseViewModel bloodGlucoseViewModel);

        BloodGlucose LastAddedBloodGlucose();
    }
}
