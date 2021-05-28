namespace ChildGlucoCare.Web.Controllers
{
    using System.Threading.Tasks;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Data;
    using ChildGlucoCare.Services.Data.Models;
    using ChildGlucoCare.Web.ViewModels.CarbohydtrateIntakes;
    using Microsoft.AspNetCore.Mvc;

    public class CarbohydrateIntakesController : Controller
    {
        private readonly ICarbohydrateIntakeService carbohydrateIntakeService;

        public CarbohydrateIntakesController(ICarbohydrateIntakeService carbohydrateIntakeService)
        {
            this.carbohydrateIntakeService = carbohydrateIntakeService;
        }

        public IActionResult AddNewCarbohydtrateIntake()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewCarbohydtrateIntake(AddNewCarbohydtrateIntakeViewModel carbohydrateIntakeViewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.carbohydrateIntakeService.AddCarbohydrateIntakeAsync(carbohydrateIntakeViewModel);
            return this.Redirect("/");

        }

        public IActionResult GetEatenBeuForMeal() 
        {
            var viewModel = new AllEatenBeuViewModel
            {
                AllBeu = this.carbohydrateIntakeService.GetAllBeu<BeuViewModel>()
            };
            return this.View(viewModel);
        }

    }
}
