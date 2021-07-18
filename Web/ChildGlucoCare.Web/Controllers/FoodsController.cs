﻿namespace ChildGlucoCare.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Data.Models.Enums;
    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Services.Data.Models;
    using ChildGlucoCare.Web.ViewModels.Foods;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class FoodsController : BaseController
    {
        private readonly IFoodsService foodsService;
        private readonly IDeletableEntityRepository<Food> foodsRepository;

        public FoodsController(
                                              IFoodsService foodsService,
                                              IDeletableEntityRepository<Food> foodsRepository)
        {
            this.foodsService = foodsService;
            this.foodsRepository = foodsRepository;
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
            return this.Redirect("/Foods/All");
        }

        public IActionResult All([FromQuery] AllFoodsViewModel query)
        {
            var foodsQuery = this.foodsRepository.All().AsQueryable();

            if (!string.IsNullOrWhiteSpace(query.SearchTerm))
            {
                foodsQuery = foodsQuery.Where(c =>
                    c.Name.ToLower().Contains(query.SearchTerm.ToLower()));
            }

            var foods = foodsQuery
           .Select(c => new FoodViewModel
           {
               Id = c.Id,
               Name = c.Name,
               GramsPerBreadUnit = c.GramsPerBreadUnit,
               GlycemicIndex = c.GlycemicIndex,
               CarbohydratePer100Grams = c.CarbohydratePer100Grams,
               FatPer100Grams = c.FatPer100Grams,
               CaloriesPer100Grams = c.CaloriesPer100Grams,
               FoodType = c.FoodType.ToString(),
               ImageUrl = c.ImageUrl,
           })
              .ToList();

            var foodTypes = Enum.GetValues(typeof(FoodType)).Cast<FoodType>().ToList();
            query.Foods = foods;
            return this.View(query);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var viewModel = await this.foodsService.GetFoodAsync<EditFoodInputModel>(id);
            return this.View(viewModel);
        }

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

        public async Task<IActionResult> Delete(int id)
        {
            await this.foodsService.DeleteFoodAsync(id);
            return this.Redirect("/Foods/All");
        }
    }
}
