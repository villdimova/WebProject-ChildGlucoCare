namespace ChildGlucoCare.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Services.Data.Models;
    using ChildGlucoCare.Services.Mapping;
    using ChildGlucoCare.Web.ViewModels.Foods;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;

    public class FoodsService : IFoodsService
    {
        private readonly IDeletableEntityRepository<Food> foodsRepository;

        public FoodsService(IDeletableEntityRepository<Food> foodsRepository)
        {
            this.foodsRepository = foodsRepository;
        }

        public async Task<Food> CreateAsync(FoodsDto foodsDto)
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

            return food;
        }

        public async Task<Food> DeleteFoodAsync(int foodId)
        {
            var food = await this.foodsRepository
                .All()
                .FirstOrDefaultAsync(x => x.Id == foodId);

            this.foodsRepository.Delete(food);
            await this.foodsRepository.SaveChangesAsync();

            return food;
        }

        public async Task<Food> EditFoodAsync(EditFoodInputModel inputModel)
        {
            var food = await this.foodsRepository
                            .All().FirstOrDefaultAsync(x => x.Id == inputModel.Id);

            food.Name = inputModel.Name;
            food.GramsPerBreadUnit = inputModel.GramsPerBreadUnit;
            food.GlycemicIndex = inputModel.GlycemicIndex;
            food.CaloriesPer100Grams = inputModel.CaloriesPer100Grams;
            food.FatPer100Grams = inputModel.FatPer100Grams;
            food.CarbohydratePer100Grams = inputModel.CarbohydratePer100Grams;

            await this.foodsRepository.SaveChangesAsync();
            return food;
        }

        public async Task<IEnumerable<T>> GetAllFoodsAsync<T>()
        {
            return await this.foodsRepository
                    .All()
                    .OrderBy(f => f.Name)
                    .To<T>()
                    .ToListAsync();
        }

        public IEnumerable<SelectListItem> GetAllNames()
        {
            var foodsNames = this.foodsRepository.All().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name,
            }).OrderBy(f => f.Text).ToList();

            return foodsNames;
        }

        public async Task<T> GetFoodAsync<T>(int foodId)
        {
            return await this.foodsRepository
                .All()
                .Where(x => x.Id == foodId)
                .To<T>()
                .FirstOrDefaultAsync();
        }

        public IEnumerable<Food> GetNames()
        {
            return this.foodsRepository.All().ToList();
        }
    }
}
