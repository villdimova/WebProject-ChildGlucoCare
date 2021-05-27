namespace ChildGlucoCare.Services.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Web.ViewModels.SportActivities;

    public class SportActivityService : ISportActivityService
    {
        private readonly IDeletableEntityRepository<Sport> sportsRepository;
        private readonly IDeletableEntityRepository<SportActivity> sportActivitiesRepository;

        public SportActivityService(
                                                     IDeletableEntityRepository<Sport> sportsRepository
                                                    , IDeletableEntityRepository<SportActivity> sportActivitiesRepository)
        {
            this.sportsRepository = sportsRepository;
            this.sportActivitiesRepository = sportActivitiesRepository;
        }

        public async Task AddAsync(AddSportActivityViewModel sportActivityViewModel)
        {
            var sport = this.sportsRepository.All().FirstOrDefault(s => s.SportName == sportActivityViewModel.SportName);

            if (sport == null)
            {
                throw new ArgumentOutOfRangeException();
            }

            var sportActivity = new SportActivity
            {
                SportName=sportActivityViewModel.SportName,
                Duration=sportActivityViewModel.Duration,
                Date=sportActivityViewModel.Date,
                UserName=sportActivityViewModel.UserName,
                ActivityLevel=sport.ActivityLevel.ToString(),
                Sport=sport,
            };

            await this.sportActivitiesRepository.AddAsync(sportActivity);
            await this.sportActivitiesRepository.SaveChangesAsync();
        }
    }
}
