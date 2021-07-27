namespace ChildGlucoCare.Web.Controllers
{
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Web.ViewModels;
    using ChildGlucoCare.Web.ViewModels.Home;
    using ChildGlucoCare.Web.ViewModels.Statistics;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IStatisticsService statisticsService;
        private readonly IUsersService usersService;

        public HomeController(
                                                UserManager<ApplicationUser> userManager,
                                                IStatisticsService statisticsService,
                                                IUsersService usersService)
        {
            this.userManager = userManager;
            this.statisticsService = statisticsService;
            this.usersService = usersService;
        }

        [Authorize]
        public async Task<IActionResult> UserDashboard()
        {
            var period = 30;
            var user = await this.userManager.GetUserAsync(this.User);
            var bloodGlucoses = this.statisticsService.GetBloodGlucoseReport(period);

            var startdate = DateTime.Today.AddDays(-period);

            var lastBloodGlucose = this.usersService.GetLastBloodGlucose(user.Id);
            var lastMeal = this.usersService.GetLastMealBEU(user.Id);
            var lastInsulinInjection = this.usersService.GetLastInsulinInjection(user.Id);
            var lastSportActivity = this.usersService.GetLastSportActivity(user.Id);

            var viewModel = new UserDashboardViewModel
            {
                LastBloodGlucose = new ViewModels.BloodGlucoses.BloodGlucoseViewModel
                {
                    Id = lastBloodGlucose.Id,
                    CurrentGlucoseLevel = lastBloodGlucose.CurrentGlucoseLevel,
                    BloodGlocoseStatus = lastBloodGlucose.BloodGlocoseStatus,
                    Date = lastBloodGlucose.Date,
                },
                LastInjection = new ViewModels.InsulinInjections.InsulinInjectionViewModel
                {
                    Id = lastInsulinInjection.Id,
                    InsulinDose = lastInsulinInjection.InsulinDose,
                    Date = lastInsulinInjection.Date,
                    CurrentGlucoselevel = lastInsulinInjection.CurrentGlucoselevel,
                    TotalMealBeu = lastInsulinInjection.TotalMealBeu,
                },
                LastMeal = new ViewModels.CarbohydtrateIntakes.CarbsViewModel
                {
                    Id = lastMeal.Id,
                    MealType = lastMeal.MealType,
                    UserName = user.UserName,
                    Date = lastMeal.Date,
                    TotalBeu = lastMeal.TotalBeu,
                },
                LastSportActivitie = new ViewModels.SportActivities.SportActivityViewModel
                {
                    Id = lastSportActivity.Id,
                    SportName = lastSportActivity.SportName,
                    ActivityLevel = lastSportActivity.ActivityLevel,
                    Duration = lastSportActivity.Duration,
                    Date = lastSportActivity.Date,
                },

                BloodGlucoseReport = new BloodGlucoseReportViewModel
                {
                    PeriodStart = startdate.ToString(),
                    LowPercentage = this.statisticsService.GetLowBloodGlucosePercentage(period),
                    NormalPercentage = this.statisticsService.GetNormalBloodGlucosePercentage(period),
                    HighPercentage = this.statisticsService.GetHighBloodGlucosePercentage(period),
                    BloodGlucoseRecords = bloodGlucoses.Count,
                    AvgBloodGlucose = this.statisticsService.GetAvgBloodGlucose(period),
                },
            };

            return this.View(viewModel);

        }

        public IActionResult Index()
        {
            if (this.User.Identity.IsAuthenticated)
            {
                return this.RedirectToAction(nameof(this.UserDashboard));
            }

            return this.View();
        }

        public IActionResult About()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> WhoAmI()
        {
            var user = await this.userManager.GetUserAsync(this.User);
            return this.Json(user);
        }
    }
}
