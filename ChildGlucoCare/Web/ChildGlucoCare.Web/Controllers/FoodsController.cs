﻿namespace ChildGlucoCare.Web.Controllers
{
    using ChildGlucoCare.Services.Data;
    using ChildGlucoCare.Services.Data.Models;
    using ChildGlucoCare.Web.ViewModels.Foods;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class FoodsController : Controller
    {
        private readonly IFoodsService foodsService;

        public FoodsController(IFoodsService foodsService)
        {
            this.foodsService = foodsService;
        }
        public IActionResult Create()
        {
            var viewModel = new CreateFoodInputModel();
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
            //  return this.Json(input);

            return this.Redirect("/");

        }
    }
}
