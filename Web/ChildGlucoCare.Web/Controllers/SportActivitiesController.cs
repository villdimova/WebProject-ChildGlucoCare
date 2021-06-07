using ChildGlucoCare.Services.Data;
using ChildGlucoCare.Web.ViewModels.SportActivities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ChildGlucoCare.Web.Controllers
{
    public class SportActivitiesController : Controller
    {
        private readonly ISportActivityService sportActivityService;
        private readonly ISportsService sportsService;

        public SportActivitiesController(
                                                            ISportActivityService sportActivityService,
                                                            ISportsService sportsService)
        {
            this.sportActivityService = sportActivityService;
            this.sportsService = sportsService;
        }

        public IActionResult AddSportActivity()
        {
            var viewModel = new AddSportActivityViewModel();
            viewModel.SportNames = this.sportsService.GetAllNames();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddSportActivity(AddSportActivityViewModel sportActivityViewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.sportActivityService.AddAsync(sportActivityViewModel);
            return this.Redirect("/");
        }
    }
}
