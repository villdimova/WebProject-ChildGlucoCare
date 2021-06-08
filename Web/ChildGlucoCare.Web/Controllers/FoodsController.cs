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

        public IActionResult Create()
        {

            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(FoodsDto foodsDto)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.foodsService.CreateAsync(foodsDto);
 
            return this.Redirect("/");

        }
    }
}
