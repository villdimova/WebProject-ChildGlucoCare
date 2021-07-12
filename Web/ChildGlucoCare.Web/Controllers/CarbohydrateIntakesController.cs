namespace ChildGlucoCare.Web.Controllers
{
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Data.Models.Enums;
    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Web.ViewModels.CarbohydtrateIntakes;
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

        public IActionResult AddNewCarbohydtrateIntake()
        {
            var viewModel = new AddNewCarbohydtrateIntakeViewModel
            {
                FoodNames = this.foodsService.GetAllNames(),
            };

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewCarbohydtrateIntake(AddNewCarbohydtrateIntakeViewModel carbohydrateIntakeViewModel)
        {
            if (!this.ModelState.IsValid)
            {
                carbohydrateIntakeViewModel.FoodNames = this.foodsService.GetAllNames();
                return this.View(carbohydrateIntakeViewModel);
            }

            var user = await this.userManager.GetUserAsync(this.User);

            await this.carbohydrateIntakeService.AddCarbohydrateIntakeAsync(carbohydrateIntakeViewModel, user.Id);
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
                SuggestedDoseInsulin = lastCarbs.SuggestedDoseInsulin,
                TotalFats = lastCarbs.TotalFat,
                GlyecemicLoad = lastCarbs.GlycemicLoad,
            };

            if ((viewModel.MealType == MealType.Breakfast || viewModel.MealType == MealType.MorningSnack)
                && viewModel.GlyecemicLoad > 15)
            {
                return this.RedirectToAction(nameof(this.AddedFoodWithHighGlygemicLoad));
            }

            if (viewModel.TotalFats > 20)
            {
                return this.AddedDangerousFatFood();
            }

            return this.View(viewModel);
        }

        public async Task<IActionResult> All()
        {
            var viewModel = new AllCarbsViewModel
            {
                AllCarbs = await this.carbohydrateIntakeService.GetAllCarbsAsync<CarbsViewModel>(),
            };
            return this.View(viewModel);
        }

        public IActionResult AddedFoodWithHighGlygemicLoad()
        {
            return this.View();
        }

        public IActionResult AddedDangerousFatFood()
        {
            return this.View();
        }

        public JsonResult GetFoodNames()
        {
            var names = this.foodsService.GetNames();

            return this.Json(names);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await this.carbohydrateIntakeService.DeleteCarbohydrateIntakeAsync(id);
            return this.RedirectToAction(nameof(this.All));
        }
    }
}
