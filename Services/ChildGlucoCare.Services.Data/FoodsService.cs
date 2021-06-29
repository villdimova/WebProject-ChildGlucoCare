namespace ChildGlucoCare.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Services.Data.Models;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class FoodsService : IFoodsService
    {
        private readonly IDeletableEntityRepository<Food> foodsRepository;

        public FoodsService(IDeletableEntityRepository<Food> foodsRepository)
        {
            this.foodsRepository = foodsRepository;
        }

        public async Task CreateAsync(FoodsDto foodsDto)
        {
            var food = new Food
            {
                Name = foodsDto.Name,
                CarbohydratePer100Grams = foodsDto.CarbohydratePer100Grams,
                FatPer100Grams = foodsDto.FatPer100Grams,
                CaloriesPer100Grams = foodsDto.CaloriesPer100Grams,
                FoodType = foodsDto.FoodType,
                GlycemicIndex = foodsDto.GlycemicIndex,
            };

            await this.foodsRepository.AddAsync(food);
            await this.foodsRepository.SaveChangesAsync();
        }

        public IEnumerable<SelectListItem> GetAllNames()
        {
            var foodsNames = this.foodsRepository.All().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name,
            });

            return foodsNames;
        }

        public IEnumerable<Food> GetNames()
        {
            return this.foodsRepository.All().ToList();
        }
    }
}
