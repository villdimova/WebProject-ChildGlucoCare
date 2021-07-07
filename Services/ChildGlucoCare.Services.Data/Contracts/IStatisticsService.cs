namespace ChildGlucoCare.Services.Data.Contracts
{
    using System;
    using System.Collections.Generic;

    using ChildGlucoCare.Data.Models;

    public interface IStatisticsService
    {
        IEnumerable<T> GetYesterdayBloodGlucoseInfo<T>();

        IEnumerable<T> GeYesterdayInsulinInjectionsInfo<T>();

        IEnumerable<T> GetYesterdaySportActivityInfo<T>();

        List<BloodGlucose> GetBloodGlucoseReport(DateTime startDate, DateTime endDate);

        string GetLowBloodGlucosePercentage(DateTime startDate, DateTime endDate);

        string GetHighBloodGlucosePercentage(DateTime startDate, DateTime endDate);

        string GetNormalBloodGlucosePercentage(DateTime startDate, DateTime endDate);

        string GetAvgBloodGlucose(DateTime startDate, DateTime endDate);
    }
}
