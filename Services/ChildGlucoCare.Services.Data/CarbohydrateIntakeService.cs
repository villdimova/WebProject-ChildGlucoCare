namespace ChildGlucoCare.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Mapping;
    using ChildGlucoCare.Web.ViewModels.CarbohydtrateIntakes;
    using Microsoft.EntityFrameworkCore;

    public class CarbohydrateIntakeService : ICarbohydrateIntakeService
    {

        private readonly IDeletableEntityRepository<CarbohydrateIntake> carbsRepository;
        private readonly IDeletableEntityRepository<Food> foodsRepository;
        private readonly IDeletableEntityRepository<FoodIntake> foodIntakesRepository;

        public CarbohydrateIntakeService(
                                                                IDeletableEntityRepository<CarbohydrateIntake> carbsRepository
                                                               , IDeletableEntityRepository<Food> foodsRepository
                                                                , IDeletableEntityRepository<FoodIntake> foodIntakesRepository)
        {
            this.carbsRepository = carbsRepository;
            this.foodsRepository = foodsRepository;
            this.foodIntakesRepository = foodIntakesRepository;
        }

        public async Task AddCarbohydrateIntakeAsync(AddNewCarbohydtrateIntakeViewModel input)
        {
            var carbohydrateIntake = new CarbohydrateIntake
            {
                UserName = input.AddedByUser,
                Date = input.Date,
                MealType = input.MealType,
            };

            foreach (var foodIntake in input.Foods)
            {
                var eatenFood = this.foodsRepository.All().FirstOrDefault(x => x.Name == foodIntake.FoodName);
                if (eatenFood == null)
                {
                    throw new ArgumentOutOfRangeException();
                }

                carbohydrateIntake.Foods.Add(new FoodIntake
                {
                    Food = eatenFood,
                    FoodName = foodIntake.FoodName,
                    Amount = foodIntake.Amount,
                    CarbohydrateIntake = carbohydrateIntake,
                });


            }

            var totalCarbs = 0;

            foreach (var food in carbohydrateIntake.Foods)
            {
                totalCarbs += (food.Amount * food.Food.CarbohydratePer100Grams) / 100;

            }

            carbohydrateIntake.TotalBeu = Math.Round(totalCarbs/12.0);

            await this.carbsRepository.AddAsync(carbohydrateIntake);
            await this.carbsRepository.SaveChangesAsync();
        }

        public IEnumerable<T> GetAllBeu<T>()
        {
            var carbs = this.carbsRepository.AllAsNoTracking()
               .OrderBy(x => x.Date).To<T>().ToList();

            return carbs;
        }

        public  CarbohydrateIntake LastAddedCarbs()
        {
            var lastCarbs = this.carbsRepository.AllAsNoTracking().OrderByDescending(x => x.Date).FirstOrDefault();

            return lastCarbs;
        }
    }
}
