namespace ChildGlucoCare.Web.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Services.Data.Models;
    using ChildGlucoCare.Web.ViewModels.CarbohydtrateIntakes;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class CarbohydrateIntakesController : BaseController
    {
        private readonly ICarbohydrateIntakeService carbohydrateIntakeService;
        private readonly IFoodsService foodsService;
        private readonly UserManager<ApplicationUser> userManager;

        public CarbohydrateIntakesController(
                                                                        ICarbohydrateIntakeService carbohydrateIntakeService,
                                                                        IFoodsService foodsService,
                                                                        UserManager<ApplicationUser> userManager)
        {
            this.carbohydrateIntakeService = carbohydrateIntakeService;
            this.foodsService = foodsService;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult AddNewCarbohydtrateIntake()
        {
            var viewModel = new AddNewCarbohydtrateIntakeViewModel
            {
                FoodNames = this.foodsService.GetAllNames(),
            };

            return this.View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddNewCarbohydtrateIntake(AddNewCarbohydtrateIntakeViewModel carbohydrateIntakeViewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(carbohydrateIntakeViewModel);
            }

            var user = await this.userManager.GetUserAsync(this.User);

            await this.carbohydrateIntakeService.AddCarbohydrateIntakeAsync(carbohydrateIntakeViewModel, user.Id);
            return this.RedirectToAction(nameof(this.SuccessfullyAdded));
        }

        [Authorize]
        public IActionResult SuccessfullyAdded()
        {
            var lastCarbs = this.carbohydrateIntakeService.LastAddedCarbs();

            var viewModel = new SuccessfullyAddedViewModel
            {
                Date = lastCarbs.Date,
                MealType = lastCarbs.MealType,
                TotalBeu = lastCarbs.TotalBeu,
                SuggestedDoseInsulin = lastCarbs.SuggestedDoseInsulin,
            };

            return this.View(viewModel);
        }

        [Authorize]
        public IActionResult GetEatenBeuForMeal()
        {
            var viewModel = new AllEatenBeuViewModel
            {
                AllBeu = this.carbohydrateIntakeService.GetAllBeu<BeuViewModel>(),
            };
            return this.View(viewModel);
        }

        [Authorize]
        public JsonResult GetFoodNames()
        {
            var names = this.foodsService.GetNames();

            return this.Json(names);
        }
    }
}
