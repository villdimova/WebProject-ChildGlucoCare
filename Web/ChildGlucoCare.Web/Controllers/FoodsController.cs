namespace ChildGlucoCare.Web.Controllers
{
    using System.Threading.Tasks;

    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Services.Data.Models;
    using ChildGlucoCare.Web.ViewModels.Foods;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class FoodsController : BaseController
    {
        private readonly IFoodsService foodsService;

        public FoodsController(IFoodsService foodsService)
        {
            this.foodsService = foodsService;
        }

        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(FoodsDto foodsDto)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.foodsService.CreateAsync(foodsDto);
            return this.Redirect("/Foods/All");
        }

        [Authorize]
        public async Task<IActionResult> All()
        {
            var viewModel = new AllFoodsViewModel
            {
                Foods = await this.foodsService.GetAllFoodsAsync<FoodViewModel>(),
            };
            return this.View(viewModel);
        }

        [Authorize]
        public async Task<IActionResult> Edit(int id)
        {
            var viewModel = await this.foodsService.GetFoodAsync<EditFoodInputModel>(id);
            return this.View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(EditFoodInputModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(inputModel);
            }

            await this.foodsService.EditFoodAsync(inputModel);
            return this.Redirect($"/Foods/All");
        }

        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            await this.foodsService.DeleteFoodAsync(id);
            return this.Redirect("/Foods/All");
        }
    }
}
