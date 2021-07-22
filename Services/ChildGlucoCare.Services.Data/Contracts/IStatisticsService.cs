namespace ChildGlucoCare.Services.Data.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Web.ViewModels.Statistics;

    public interface IStatisticsService
    {
        Task<StatisticPeriod> AddStatisticPeriod(GetPeriodStatisticInputModel input, ApplicationUser user);

        int GetStatisticPeriod(ApplicationUser user);

        IEnumerable<T> GetBloodGlucoseInfo<T>(int period);

        IEnumerable<T> GetInsulinInjectionsInfo<T>(int period);

        IEnumerable<T> GetSportActivityInfo<T>(int period);

        List<BloodGlucose> GetBloodGlucoseReport(int period);

        string GetLowBloodGlucosePercentage(int period);

        string GetHighBloodGlucosePercentage(int period);

        string GetNormalBloodGlucosePercentage(int period);

        string GetAvgBloodGlucose(int period);
    }
}
