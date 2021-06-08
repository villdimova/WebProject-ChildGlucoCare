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

    public class CarbohydrateIntakesController : Controller
    {
        private readonly ICarbohydrateIntakeService carbohydrateIntakeService;
        private readonly IFoodsService foodsService;
        private readonly UserManager<ApplicationUser> userManager;

        public CarbohydrateIntakesController(ICarbohydrateIntakeService carbohydrateIntakeService
                                                                        , IFoodsService foodsService
                                                                         , UserManager<ApplicationUser> userManager)
        {
            this.carbohydrateIntakeService = carbohydrateIntakeService;
            this.foodsService = foodsService;
            this.userManager = userManager;
        }

        public IActionResult AddNewCarbohydtrateIntake()
        {
            var viewModel = new AddNewCarbohydtrateIntakeViewModel();
            viewModel.FoodNames = this.foodsService.GetAllNames();
            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddNewCarbohydtrateIntake(AddNewCarbohydtrateIntakeViewModel carbohydrateIntakeViewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var user = await this.userManager.GetUserAsync(this.User);

            await this.carbohydrateIntakeService.AddCarbohydrateIntakeAsync(carbohydrateIntakeViewModel,user.Id);
            return this.RedirectToAction(nameof(this.SuccessfullyAdded));

        }

        public IActionResult SuccessfullyAdded()
        {
            var lastCarbs = this.carbohydrateIntakeService.LastAddedCarbs();

            var viewModel = new SuccessfullyAddedViewModel
            {
                Date = lastCarbs.Date,
                MealType = lastCarbs.MealType,
                TotalBeu = lastCarbs.TotalBeu,
                SuggestedDoseInsulin=lastCarbs.SuggestedDoseInsulin,

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

        public JsonResult GetFoodNames()
        {
            var names = this.foodsService.GetNames();
            
            return Json (names);
        }

    }
}
