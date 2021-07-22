namespace ChildGlucoCare.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Data.Models.Enums;
    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Services.Mapping;
    using ChildGlucoCare.Web.ViewModels.Statistics;
    using Microsoft.EntityFrameworkCore;

    public class StatisticsService : IStatisticsService
    {
        private readonly IDeletableEntityRepository<SportActivity> sportActivitiesRepository;
        private readonly IDeletableEntityRepository<InsulinInjection> insulinsRepository;
        private readonly IDeletableEntityRepository<BloodGlucose> bloodGlucosesRepository;
        private readonly IDeletableEntityRepository<StatisticPeriod> statisticsRepository;
        private readonly IUsersService usersService;

        public StatisticsService(
                                                                IDeletableEntityRepository<SportActivity> sportActivitiesRepository,
                                                                IDeletableEntityRepository<InsulinInjection> insulinsRepository,
                                                                IDeletableEntityRepository<BloodGlucose> bloodGlucosesRepository,
                                                                 IDeletableEntityRepository<StatisticPeriod> statisticsRepository,
                                                                IUsersService usersService)
        {
            this.sportActivitiesRepository = sportActivitiesRepository;
            this.insulinsRepository = insulinsRepository;
            this.bloodGlucosesRepository = bloodGlucosesRepository;
            this.statisticsRepository = statisticsRepository;
            this.usersService = usersService;
        }

        public string GetAvgBloodGlucose(int period)
        {
            var bloodGlucoses = this.GetBloodGlucoseReport(period);

            return $"{bloodGlucoses.Average(x => x.CurrentGlucoseLevel):f2}";
        }

        public string GetHighBloodGlucosePercentage(int period)
        {
            var bloodGlucoses = this.GetBloodGlucoseReport(period);

            var highBloodglucoses = bloodGlucoses.Where(x => x.BloodGlocoseStatus == BloodGlocoseStatus.High).ToList().Count();
            double highBloodGlucosesPercentage = (double)highBloodglucoses / bloodGlucoses.Count() * 100;

            return $"{highBloodGlucosesPercentage:f2}%";
        }

        public string GetLowBloodGlucosePercentage(int period)
        {
            var bloodGlucoses = this.GetBloodGlucoseReport(period);

            var lowBloodglucoses = bloodGlucoses.Where(x => x.BloodGlocoseStatus == BloodGlocoseStatus.Low).ToList().Count();
            double lowBloodGlucosesPercentage = (double)lowBloodglucoses / bloodGlucoses.Count() * 100;

            return $"{lowBloodGlucosesPercentage:f2}%";
        }

        public string GetNormalBloodGlucosePercentage(int period)
        {
            var bloodGlucoses = this.GetBloodGlucoseReport(period);

            var normalBloodglucoses = bloodGlucoses.Where(x => x.BloodGlocoseStatus == BloodGlocoseStatus.Normal).ToList().Count();
            double normalBloodGlucosesPercentage = (double)normalBloodglucoses / bloodGlucoses.Count() * 100;

            return $"{normalBloodGlucosesPercentage:f2}%";
        }

        public List<BloodGlucose> GetBloodGlucoseReport(int period)
        {
            var startDate = DateTime.Today.AddDays(-period);
            var bloodGlucoses = this.bloodGlucosesRepository
                .All()
                .Where(x => x.Date.Date >= startDate)
                .ToList();

            return bloodGlucoses;
        }

        public IEnumerable<T> GetBloodGlucoseInfo<T>(int period)
        {
            var startDate = DateTime.Today.AddDays(-period);
            var bloodGlucoses = this.bloodGlucosesRepository
                .All()
                .Where(x => x.Date.Date >= startDate)
                .To<T>().ToList();

            return bloodGlucoses;
        }

        public IEnumerable<T> GetSportActivityInfo<T>(int period)
        {
            var startDate = DateTime.Today.AddDays(-period);
            var sportActivities = this.sportActivitiesRepository
                .All()
                .Where(x => x.Date.Date >= startDate)
                .To<T>()
                .ToList();

            return sportActivities;
        }

        public IEnumerable<T> GetInsulinInjectionsInfo<T>(int period)
        {
            var startDate = DateTime.Today.AddDays(-period);
            var injections = this.insulinsRepository
                .All()
                .Where(x => x.Date.Date >= startDate)
                .To<T>()
                .ToList();

            return injections;
        }

        public async Task<StatisticPeriod> AddStatisticPeriod(GetPeriodStatisticInputModel input, ApplicationUser user)
        {
            var statistic = new StatisticPeriod
            {
                Days = input.Days,
                ApplicationUserId = user.Id,
            };
            await this.statisticsRepository.AddAsync(statistic);
            await this.statisticsRepository.SaveChangesAsync();

            return statistic;
        }

        public int GetStatisticPeriod(ApplicationUser user)
        {
            var statistics = this.statisticsRepository
                .All()
                .Where(x => x.ApplicationUserId == user.Id)
                 .OrderByDescending(x => x.Id)
                .ToList();

            var days = statistics.Select(x => x.Days).First();

            return days;
        }
    }
}
