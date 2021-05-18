namespace ChildGlucoCare.Services.Data
{
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Data.Models;

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
                FoodImageUrl = foodsDto.FoodImageUrl,
            };
            await this.foodsRepository.AddAsync(food);
            await this.foodsRepository.SaveChangesAsync();
        }

    }
}
