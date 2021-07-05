namespace ChildGlucoCare.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
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
