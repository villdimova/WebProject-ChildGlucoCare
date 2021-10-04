namespace ChildGlucoCare.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
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

        public IActionResult AddStatisticPeriod()
        {

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddStatisticPeriod(GetPeriodStatisticInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            var user = await this.userManager.GetUserAsync(this.User);

            await this.statisticsService.AddStatisticPeriod(input, user);

            return this.RedirectToAction(nameof(this.GetStatistics));
        }

        public IActionResult AddReportPeriod()
        {

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddReportPeriod(GetPeriodStatisticInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            var user = await this.userManager.GetUserAsync(this.User);

            await this.statisticsService.AddStatisticPeriod(input, user);

            return this.RedirectToAction(nameof(this.BloodGlucoseReport));
        }

        public async Task<IActionResult> BloodGlucoseReport()
        {
            var user = await this.userManager.GetUserAsync(this.User);
            int days = this.statisticsService.GetStatisticPeriod(user);

            var viewModel = this.GetReportInfo(days);

            return this.View(viewModel);
        }

        public async Task<IActionResult> GetStatistics()
        {
            var user = await this.userManager.GetUserAsync(this.User);
            int days = this.statisticsService.GetStatisticPeriod(user);

            var viewModel = new StatisticInfoViewModel
            {
                BloodGlucoses = this.statisticsService.GetBloodGlucoseInfo<ViewModels.BloodGlucoses.BloodGlucoseViewModel>(days),
                InsulinInjections = this.statisticsService.GetInsulinInjectionsInfo<InsulinInjectionViewModel>(days),
                SportActivities = this.statisticsService.GetSportActivityInfo<SportActivityViewModel>(days),
            };

            return this.View(viewModel);
        }

        private BloodGlucoseReportViewModel GetReportInfo(int period)
        {

            var bloodGlucoses = this.statisticsService.GetBloodGlucoseReport(period);
            var viewModel = new BloodGlucoseReportViewModel();
            if (bloodGlucoses.Any())
            {
                var startdate = DateTime.Today.AddDays(-period);
                viewModel = new BloodGlucoseReportViewModel
                {
                    PeriodStart = startdate.ToString(),
                    LowPercentage = this.statisticsService.GetLowBloodGlucosePercentage(period),
                    NormalPercentage = this.statisticsService.GetNormalBloodGlucosePercentage(period),
                    HighPercentage = this.statisticsService.GetHighBloodGlucosePercentage(period),
                    BloodGlucoseRecords = bloodGlucoses.Count,
                    AvgBloodGlucose = this.statisticsService.GetAvgBloodGlucose(period),
                };
            }
          
            return viewModel;
        }
    }
}
