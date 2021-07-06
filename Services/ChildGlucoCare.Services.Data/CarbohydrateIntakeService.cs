namespace ChildGlucoCare.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Data.Models.Enums;
    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Services.Mapping;
    using ChildGlucoCare.Web.ViewModels.BloodGlucoses;
    using ChildGlucoCare.Web.ViewModels.CarbohydtrateIntakes;
    using Microsoft.EntityFrameworkCore;

    public class CarbohydrateIntakeService : ICarbohydrateIntakeService
    {
        private readonly IDeletableEntityRepository<CarbohydrateIntake> carbsRepository;
        private readonly IDeletableEntityRepository<Food> foodsRepository;
        private readonly IDeletableEntityRepository<FoodIntake> foodIntakesRepository;
        private readonly IDeletableEntityRepository<Insulin> insulinsRepository;
        private readonly IDeletableEntityRepository<BloodGlucose> bloodGlucosesRepository;
        private readonly IBloodGlucoseService bloodGlucoseService;
        private readonly IUsersService usersService;

        public CarbohydrateIntakeService(
                                                                IDeletableEntityRepository<CarbohydrateIntake> carbsRepository,
                                                                IDeletableEntityRepository<Food> foodsRepository,
                                                                IDeletableEntityRepository<FoodIntake> foodIntakesRepository,
                                                                IDeletableEntityRepository<Insulin> insulinsRepository,
                                                                IDeletableEntityRepository<BloodGlucose> bloodGlucosesRepository,
                                                                IBloodGlucoseService bloodGlucoseService,
                                                                IUsersService usersService)
        {
            this.carbsRepository = carbsRepository;
            this.foodsRepository = foodsRepository;
            this.foodIntakesRepository = foodIntakesRepository;
            this.insulinsRepository = insulinsRepository;
            this.bloodGlucosesRepository = bloodGlucosesRepository;
            this.bloodGlucoseService = bloodGlucoseService;
            this.usersService = usersService;
        }

        public async Task AddCarbohydrateIntakeAsync(AddNewCarbohydtrateIntakeViewModel input, string userId)
        {
            var carbohydrateIntake = new CarbohydrateIntake
            {
                Date = input.Date,
                MealType = input.MealType,
                ApplicationUser = await this.usersService.GetUserByIdAsync(userId),
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

            var insulinSensitivity = carbohydrateIntake.ApplicationUser.InsulinSensitivity;
            carbohydrateIntake.TotalBeu = Math.Round(totalCarbs / 12.0);
            carbohydrateIntake.SuggestedDoseInsulin = this.CalculateProperInsulinDose(input, carbohydrateIntake.TotalBeu, insulinSensitivity);

            await this.carbsRepository.AddAsync(carbohydrateIntake);
            await this.carbsRepository.SaveChangesAsync();

            var viewModel = new AddBloodGlucoseViewModel
            {
                CurrentGlucoseLevel = input.CurrentGlucoseLevel,
                Date = input.Date,
                InsulinSensitivity = carbohydrateIntake.ApplicationUser.InsulinSensitivity,
            };

            await this.bloodGlucoseService.AddBloodGlucoseAsync(viewModel, userId);
        }

        public double CalculateProperInsulinDose(AddNewCarbohydtrateIntakeViewModel carbohydrateIntake, double totalBeu, double insulinSensitivity)
        {
            var currentBloodGlucose = carbohydrateIntake.CurrentGlucoseLevel;
            var correction = 0.0;
            if (currentBloodGlucose > 7.5)
            {
                correction = (currentBloodGlucose - 6) / insulinSensitivity;
            }

            var mealType = carbohydrateIntake.MealType;
            double dayPartInsulinRatio = this.GetdayPartInsulinRatio(mealType);
            var neededInsulin = (totalBeu * dayPartInsulinRatio) + correction;
            return Math.Round(neededInsulin * 2, MidpointRounding.AwayFromZero) / 2;
        }

        public async Task<CarbohydrateIntake> DeleteCarbohydrateIntakeAsync(int carbohydrateIntakeId)
        {
            var carbohydrateIntake = await this.carbsRepository
                .All()
                .FirstOrDefaultAsync(x => x.Id == carbohydrateIntakeId);

            this.carbsRepository.Delete(carbohydrateIntake);
            await this.foodsRepository.SaveChangesAsync();

            return carbohydrateIntake;
        }

        public async Task<IEnumerable<T>> GetAllCarbsAsync<T>()
        {
            return await this.carbsRepository.
                All()
               .OrderBy(x => x.Date)
               .To<T>()
               .ToListAsync();
        }

        public Task<T> GetCarbohydrateIntakeAsync<T>(int foodId)
        {
            throw new NotImplementedException();
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
