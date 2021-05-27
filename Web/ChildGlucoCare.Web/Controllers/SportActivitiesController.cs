using ChildGlucoCare.Services.Data;
using ChildGlucoCare.Web.ViewModels.SportActivities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ChildGlucoCare.Web.Controllers
{
    public class SportActivitiesController : Controller
    {
        private readonly ISportActivityService sportActivityService;

        public SportActivitiesController(ISportActivityService sportActivityService)
        {
            this.sportActivityService = sportActivityService;
        }

        public IActionResult AddSportActivity()
        {
            return this.View();
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
