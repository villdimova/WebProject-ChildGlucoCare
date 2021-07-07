namespace ChildGlucoCare.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Data.Models.Enums;
    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Services.Mapping;

    public class StatisticsService : IStatisticsService
    {
        private readonly IDeletableEntityRepository<SportActivity> sportActivitiesRepository;
        private readonly IDeletableEntityRepository<InsulinInjection> insulinsRepository;
        private readonly IDeletableEntityRepository<BloodGlucose> bloodGlucosesRepository;
        private readonly IUsersService usersService;

        public StatisticsService(
                                                                IDeletableEntityRepository<SportActivity> sportActivitiesRepository,
                                                                IDeletableEntityRepository<InsulinInjection> insulinsRepository,
                                                                IDeletableEntityRepository<BloodGlucose> bloodGlucosesRepository,
                                                                IUsersService usersService)
        {
            this.sportActivitiesRepository = sportActivitiesRepository;
            this.insulinsRepository = insulinsRepository;
            this.bloodGlucosesRepository = bloodGlucosesRepository;
            this.usersService = usersService;
        }

        public string GetAvgBloodGlucose(DateTime startDate, DateTime endDate)
        {
            var bloodGlucoses = this.GetBloodGlucoseReport(startDate, endDate);

            return $"{bloodGlucoses.Average(x => x.CurrentGlucoseLevel):f2}";
        }

        public string GetHighBloodGlucosePercentage(DateTime startDate, DateTime endDate)
        {
            var bloodGlucoses = this.GetBloodGlucoseReport(startDate, endDate);

            var highBloodglucoses = bloodGlucoses.Where(x => x.BloodGlocoseStatus == BloodGlocoseStatus.High).ToList().Count();
            double highBloodGlucosesPercentage = (double)highBloodglucoses / bloodGlucoses.Count() * 100;

            return $"{highBloodGlucosesPercentage:f2}%";
        }

        public string GetLowBloodGlucosePercentage(DateTime startDate, DateTime endDate)
        {
            var bloodGlucoses = this.GetBloodGlucoseReport(startDate, endDate);

            var lowBloodglucoses = bloodGlucoses.Where(x => x.BloodGlocoseStatus == BloodGlocoseStatus.Low).ToList().Count();
            double lowBloodGlucosesPercentage = (double)lowBloodglucoses / bloodGlucoses.Count() * 100;

            return $"{lowBloodGlucosesPercentage:f2}%";
        }

        public string GetNormalBloodGlucosePercentage(DateTime startDate, DateTime endDate)
        {
            var bloodGlucoses = this.GetBloodGlucoseReport(startDate, endDate);

            var normalBloodglucoses = bloodGlucoses.Where(x => x.BloodGlocoseStatus == BloodGlocoseStatus.Normal).ToList().Count();
            double normalBloodGlucosesPercentage = (double)normalBloodglucoses / bloodGlucoses.Count() * 100;

            return $"{normalBloodGlucosesPercentage:f2}%";
        }

        public List<BloodGlucose> GetBloodGlucoseReport(DateTime startDate, DateTime endDate)
        {
            var bloodGlucoses = this.bloodGlucosesRepository
                .All()
                .Where(x => x.Date.Date >= startDate && x.Date <= endDate)
                .ToList();

            return bloodGlucoses;
        }

        public IEnumerable<T> GetYesterdayBloodGlucoseInfo<T>()
        {
            var yesterday = DateTime.Today.AddDays(-1);
            var bloodGlucoses = this.bloodGlucosesRepository.All().Where(x => x.Date.Date == yesterday.Date).To<T>().ToList();

            return bloodGlucoses;
        }

        public IEnumerable<T> GetYesterdaySportActivityInfo<T>()
        {
            var yesterday = DateTime.Today.AddDays(-1);
            var sportActivities = this.sportActivitiesRepository.All().Where(x => x.Date.Date == yesterday.Date).To<T>().ToList();

            return sportActivities;
        }

        public IEnumerable<T> GeYesterdayInsulinInjectionsInfo<T>()
        {
            var yesterday = DateTime.Today.AddDays(-1);
            var injections = this.insulinsRepository.All().Where(x => x.Date.Date == yesterday.Date).To<T>().ToList();

            return injections;
        }
    }
}
