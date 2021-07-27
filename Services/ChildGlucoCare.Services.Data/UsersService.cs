namespace ChildGlucoCare.Services.Data
{
    using System.Linq;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Data.Contracts;
    using Microsoft.EntityFrameworkCore;

    public class UsersService : IUsersService
    {
        private readonly IDeletableEntityRepository<ApplicationUser> userRepository;
        private readonly IDeletableEntityRepository<CarbohydrateIntake> meals;
        private readonly IDeletableEntityRepository<BloodGlucose> bloodGlucoses;
        private readonly IDeletableEntityRepository<SportActivity> sportActivities;
        private readonly IDeletableEntityRepository<InsulinInjection> injections;

        public UsersService(
                                        IDeletableEntityRepository<ApplicationUser> userRepository,
                                        IDeletableEntityRepository<CarbohydrateIntake> meals,
                                        IDeletableEntityRepository<BloodGlucose> bloodGlucoses,
                                        IDeletableEntityRepository<SportActivity> sportActivities,
                                        IDeletableEntityRepository<InsulinInjection> injections)
        {
            this.userRepository = userRepository;
            this.meals = meals;
            this.bloodGlucoses = bloodGlucoses;
            this.sportActivities = sportActivities;
            this.injections = injections;
        }

        public BloodGlucose GetLastBloodGlucose(string userId)
        {
            var bloodGlucoses = this.bloodGlucoses.AllAsNoTracking().OrderByDescending(x => x.Date).ToList();
            var lastBloodGlucose = bloodGlucoses.First();

            return lastBloodGlucose;
        }

        public InsulinInjection GetLastInsulinInjection(string userId)
        {
            var injections = this.injections.AllAsNoTracking().OrderByDescending(x => x.Date).ToList();
            var lastInjection = injections.First();

            return lastInjection;
        }

        public CarbohydrateIntake GetLastMealBEU(string userId)
        {
            var meals = this.meals.AllAsNoTracking().OrderByDescending(x => x.Date).ToList();
            var lastMeal = meals.First();

            return lastMeal;
        }

        public SportActivity GetLastSportActivity(string userId)
        {
            var sportActivities = this.sportActivities.AllAsNoTracking().OrderByDescending(x => x.Date).ToList();
            var lastSportActivity = sportActivities.First();

            return lastSportActivity;
        }

        public async Task<ApplicationUser> GetUserByIdAsync(string id)
        {
            return await this.userRepository
                .All()
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
