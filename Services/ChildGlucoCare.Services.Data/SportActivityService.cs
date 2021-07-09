namespace ChildGlucoCare.Services.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Web.ViewModels.SportActivities;

    public class SportActivityService : ISportActivityService
    {
        private readonly IDeletableEntityRepository<Sport> sportsRepository;
        private readonly IDeletableEntityRepository<SportActivity> sportActivitiesRepository;
        private readonly IUsersService usersService;

        public SportActivityService(
                                                     IDeletableEntityRepository<Sport> sportsRepository,
                                                     IDeletableEntityRepository<SportActivity> sportActivitiesRepository,
                                                     IUsersService usersService)
        {
            this.sportsRepository = sportsRepository;
            this.sportActivitiesRepository = sportActivitiesRepository;
            this.usersService = usersService;
        }

        public async Task AddAsync(AddSportActivityViewModel sportActivityViewModel, string userId)
        {
            var sport = this.sportsRepository.All().FirstOrDefault(s => s.Id.ToString() == sportActivityViewModel.SportName);

            var sportActivity = new SportActivity
            {
                SportName = sport.SportName,
                Duration = sportActivityViewModel.Duration,
                Date = sportActivityViewModel.Date,
                ActivityLevel = sport.ActivityLevel.ToString(),
                Sport = sport,
                ApplicationUser = await this.usersService.GetUserByIdAsync(userId),
            };

            await this.sportActivitiesRepository.AddAsync(sportActivity);
            await this.sportActivitiesRepository.SaveChangesAsync();
        }
    }
}
