namespace ChildGlucoCare.Services.Data.Contracts
{
    using System.Collections.Generic;

    public interface IStatisticsService
    {
        IEnumerable<T> GetYesterdayBloodGlucoseInfo<T>();

        IEnumerable<T> GeYesterdayInsulinInjectionsInfo<T>();

        IEnumerable<T> GetYesterdaySportActivityInfo<T>();
    }
}
