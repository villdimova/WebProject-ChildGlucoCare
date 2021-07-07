namespace ChildGlucoCare.Web.Controllers
{
    using System;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Web.ViewModels.BloodGlucoses;
    using ChildGlucoCare.Web.ViewModels.CarbohydtrateIntakes;
    using ChildGlucoCare.Web.ViewModels.InsulinInjections;
    using ChildGlucoCare.Web.ViewModels.SportActivities;
    using ChildGlucoCare.Web.ViewModels.Statistics;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class StatisticsController : BaseController
    {
        private readonly IStatisticsService statisticsService;
        private readonly UserManager<ApplicationUser> userManager;

        public StatisticsController(
                                                   IStatisticsService statisticsService,
                                                   UserManager<ApplicationUser> userManager)
        {
            this.statisticsService = statisticsService;
            this.userManager = userManager;
        }

        public IActionResult YesterdayInsulinInfo()
        {
            var viewModel = new StatisticInfoViewModel
            {
                YesterdayInsulinInjections = this.statisticsService.GeYesterdayInsulinInjectionsInfo<InsulinInjectionViewModel>(),
            };
            return this.View(viewModel);
        }

        public IActionResult WeeklyBloodGlucoseReport()
        {
            var startDate = DateTime.Today.AddDays(-7);

            var viewModel = this.GetReportInfo(startDate.Date, DateTime.Today);

            return this.View(viewModel);
        }

        public IActionResult YesterdayBloodGlucoseInfo()
        {
            var viewModel = new StatisticInfoViewModel
            {
                YesterdayBloodGlucoses = this.statisticsService.GetYesterdayBloodGlucoseInfo<ViewModels.BloodGlucoses.BloodGlucoseViewModel>(),
            };
            return this.View(viewModel);
        }

        public IActionResult YesterdaySportActivityInfo()
        {
            var viewModel = new StatisticInfoViewModel
            {
                YesterdaySportActivities = this.statisticsService.GetYesterdaySportActivityInfo<SportActivityViewModel>(),
            };
            return this.View(viewModel);
        }

        public IActionResult WeeklyInfo()
        {
            return this.View();
        }

        public IActionResult MonthlyInfo()
        {
            return this.View();
        }

        private BloodGlucoseReportViewModel GetReportInfo(DateTime startDate, DateTime endDate)
        {
            var bloodGlucoses = this.statisticsService.GetBloodGlucoseReport(startDate, DateTime.Today);

            var viewModel = new BloodGlucoseReportViewModel
            {
                PeriodStart = startDate.ToString(),
                LowPercentage = this.statisticsService.GetLowBloodGlucosePercentage(startDate, DateTime.Today),
                NormalPercentage = this.statisticsService.GetNormalBloodGlucosePercentage(startDate, DateTime.Today),
                HighPercentage = this.statisticsService.GetHighBloodGlucosePercentage(startDate, DateTime.Today),
                BloodGlucoseRecords = bloodGlucoses.Count,
                AvgBloodGlucose = this.statisticsService.GetAvgBloodGlucose(startDate, DateTime.Today),
            };
            return viewModel;
        }
    }
}
