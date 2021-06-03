namespace ChildGlucoCare.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Data.Models.Enums;
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

            carbohydrateIntake.TotalBeu = Math.Round(totalCarbs / 12.0);
            carbohydrateIntake.SuggestedDoseInsulin = this.CalculateProperInsulinDose(input, carbohydrateIntake.TotalBeu);


            await this.carbsRepository.AddAsync(carbohydrateIntake);
            await this.carbsRepository.SaveChangesAsync();
        }

        //TODO:When add user to finish insulin dose by adding correction dose insulin
        public double CalculateProperInsulinDose(AddNewCarbohydtrateIntakeViewModel carbohydrateIntake, double totalBeu)
        {
            var currentBloodGlucose = carbohydrateIntake.CurrentGlucoseLevel;
            var mealType = carbohydrateIntake.MealType;
            var tatalBeu = totalBeu;
            double neededInsulin = 0;
            double dayPartInsulinRatio = this.GetdayPartInsulinRatio(mealType);
            neededInsulin = totalBeu * dayPartInsulinRatio;
            return Math.Round(neededInsulin * 2, MidpointRounding.AwayFromZero) / 2;
        }

        public IEnumerable<T> GetAllBeu<T>()
        {
            var carbs = this.carbsRepository.AllAsNoTracking()
               .OrderBy(x => x.Date).To<T>().ToList();

            return carbs;
        }

        public CarbohydrateIntake LastAddedCarbs()
        {
            var lastCarbs = this.carbsRepository.AllAsNoTracking().OrderByDescending(x => x.Id).FirstOrDefault();

            return lastCarbs;
        }

        private double GetdayPartInsulinRatio(MealType mealType)
        {
            double dayPartInsulinRatio = 0;

            if (mealType == MealType.Breakfast)
            {
                dayPartInsulinRatio = 1.15;
            }
            else if (mealType == MealType.MorningSnack)
            {
                dayPartInsulinRatio = 1.15;
            }
            else if (mealType == MealType.Lunch)
            {
                dayPartInsulinRatio = 0.85;
            }
            else if (mealType == MealType.AfternoonSnack)
            {
                dayPartInsulinRatio = 0.75;
            }
            else if (mealType == MealType.Dinner)
            {
                dayPartInsulinRatio = 0.90;
            }
            else if (mealType == MealType.AfterDinnerSnack)
            {
                dayPartInsulinRatio = 0.90;
            }

            return dayPartInsulinRatio;
        }
    }
}
