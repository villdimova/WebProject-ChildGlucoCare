namespace ChildGlucoCare.Services.Data.Contracts
{
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Models;

    public interface IUsersService
    {
        public Task<ApplicationUser> GetUserByIdAsync(string id);

        public InsulinInjection GetLastInsulinInjection(string userId);

        public SportActivity GetLastSportActivity(string userId);

        public CarbohydrateIntake GetLastMealBEU(string userId);

        public BloodGlucose GetLastBloodGlucose(string userId);
    }
}
