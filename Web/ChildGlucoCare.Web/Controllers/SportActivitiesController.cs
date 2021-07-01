namespace ChildGlucoCare.Web.Controllers
{
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Web.ViewModels.SportActivities;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class SportActivitiesController : BaseController
    {
        private readonly ISportActivityService sportActivityService;
        private readonly ISportsService sportsService;
        private readonly UserManager<ApplicationUser> userManager;

        public SportActivitiesController(
                                                            ISportActivityService sportActivityService,
                                                            ISportsService sportsService,
                                                            UserManager<ApplicationUser> userManager)
        {
            this.sportActivityService = sportActivityService;
            this.sportsService = sportsService;
            this.userManager = userManager;
        }

        public IActionResult AddSportActivity()
        {
            var viewModel = new AddSportActivityViewModel
            {
                SportNames = this.sportsService.GetAllNames(),
            };

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddSportActivity(AddSportActivityViewModel sportActivityViewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(sportActivityViewModel);
            }

            var user = await this.userManager.GetUserAsync(this.User);
            await this.sportActivityService.AddAsync(sportActivityViewModel, user.Id);
            return this.Redirect("/");
        }
    }
}
