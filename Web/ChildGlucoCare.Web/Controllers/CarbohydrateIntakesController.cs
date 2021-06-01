namespace ChildGlucoCare.Web.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Data;
    using ChildGlucoCare.Services.Data.Models;
    using ChildGlucoCare.Web.ViewModels.CarbohydtrateIntakes;
    using Microsoft.AspNetCore.Mvc;

    public class CarbohydrateIntakesController : Controller
    {
        private readonly ICarbohydrateIntakeService carbohydrateIntakeService;
        private readonly IFoodsService foodsService;

        public CarbohydrateIntakesController(ICarbohydrateIntakeService carbohydrateIntakeService, IFoodsService foodsService)
        {
            this.carbohydrateIntakeService = carbohydrateIntakeService;
            this.foodsService = foodsService;
        }


        public IActionResult AddNewCarbohydtrateIntake()
        {
            var viewModel = new AddNewCarbohydtrateIntakeViewModel();
            viewModel.FoodNames = this.foodsService.GetAllNames();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewCarbohydtrateIntake(AddNewCarbohydtrateIntakeViewModel carbohydrateIntakeViewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.carbohydrateIntakeService.AddCarbohydrateIntakeAsync(carbohydrateIntakeViewModel);
            return this.RedirectToAction(nameof(this.SuccessfullyAdded));

        }

        public IActionResult SuccessfullyAdded()
        {
            var lastCarbs = this.carbohydrateIntakeService.LastAddedCarbs();

            var viewModel = new SuccessfullyAddedViewModel
            {
                Date = lastCarbs.Date,
                UserName = lastCarbs.UserName,
                MealType = lastCarbs.MealType,
                TotalBeu = lastCarbs.TotalBeu,

            };
            return this.View(viewModel);
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
