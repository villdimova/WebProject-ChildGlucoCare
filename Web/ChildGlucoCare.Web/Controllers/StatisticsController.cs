namespace ChildGlucoCare.Web.Controllers
{
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

    public class StatisticsController : Controller
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

        [Authorize]
        public IActionResult YesterdayInsulinInfo()
        {
            var viewModel = new StatisticInfoViewModel
            {
              YesterdayInsulinInjections = this.statisticsService.GeYesterdayInsulinInjectionsInfo<InsulinInjectionViewModel>(),
            };
            return this.View(viewModel);
        }

        [Authorize]
        public IActionResult YesterdayBloodGlucoseInfo()
        {
            var viewModel = new StatisticInfoViewModel
            {
                YesterdayBloodGlucoses = this.statisticsService.GetYesterdayBloodGlucoseInfo<BloodGlucoseViewModel>(),
            };
            return this.View(viewModel);
        }

        [Authorize]
        public IActionResult YesterdaySportActivityInfo()
        {
            var viewModel = new StatisticInfoViewModel
            {
                YesterdaySportActivities = this.statisticsService.GetYesterdaySportActivityInfo<SportActivityViewModel>(),
            };
            return this.View(viewModel);
        }

        [Authorize]
        public IActionResult WeeklyInfo()
        {
            return this.View();
        }

        [Authorize]
        public IActionResult MonthlyInfo()
        {
            return this.View();
        }
    }
}
