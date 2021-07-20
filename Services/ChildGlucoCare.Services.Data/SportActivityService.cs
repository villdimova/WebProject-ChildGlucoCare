namespace ChildGlucoCare.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Services.Mapping;
    using ChildGlucoCare.Web.ViewModels.SportActivities;
    using Microsoft.EntityFrameworkCore;

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

        public async  Task<SportActivity> DeleteSportActivityAsync(int sportActivityId)
        {
            var sportActivity = await this.sportActivitiesRepository
               .All()
               .FirstOrDefaultAsync(x => x.Id == sportActivityId);

            this.sportActivitiesRepository.Delete(sportActivity);
            await this.sportActivitiesRepository.SaveChangesAsync();

            return sportActivity;
        }

        public async Task<SportActivity> EditSportActivityAsync(EditSportActivityInputModel inputModel)
        {
            var sport = this.sportsRepository.All().FirstOrDefault(i => i.Id.ToString() == inputModel.SportName);
            var sportActivity = await this.sportActivitiesRepository
                             .All().FirstOrDefaultAsync(x => x.Id == inputModel.Id);

            sportActivity.Date = inputModel.Date;
            sportActivity.Sport = sport;
            sportActivity.Duration = inputModel.Duration;
            sportActivity.ActivityLevel = sport.ActivityLevel.ToString();
            sportActivity.Date = inputModel.Date;

            await this.sportActivitiesRepository.SaveChangesAsync();
            return sportActivity;
        }

        public async Task<IEnumerable<T>> GetAll<T>()
        {
            return await this.sportActivitiesRepository
             .All()
             .OrderByDescending(x => x.Date)
             .To<T>()
             .ToListAsync();
        }

        public async Task<T> GetSportActivityAsync<T>(int sportActivityId)
        {
            return await this.sportActivitiesRepository
                        .All()
                        .Where(x => x.Id == sportActivityId)
                        .To<T>()
                        .FirstOrDefaultAsync();
        }
    }
}
