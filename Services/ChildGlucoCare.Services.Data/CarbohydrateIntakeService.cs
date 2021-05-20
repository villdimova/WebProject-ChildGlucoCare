namespace ChildGlucoCare.Services.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Web.ViewModels.CarbohydtrateIntakes;

    public class CarbohydrateIntakeService : ICarbohydrateIntakeService
    {

        private readonly IDeletableEntityRepository<CarbohydrateIntake> carbsRepository;
        private readonly IDeletableEntityRepository<Food> foodsRepository;

        public CarbohydrateIntakeService(
                                                                IDeletableEntityRepository<CarbohydrateIntake> carbsRepository
                                                               , IDeletableEntityRepository<Food> foodsRepository)
        {
            this.carbsRepository = carbsRepository;
            this.foodsRepository = foodsRepository;
        }

        public int GetBeuFromCarbohydrate()
        {
            var foods = this.foodsRepository.All().ToList();

            int totalCarbs = 0;
            foreach (var food in foods)
            {
                var foodCarbs = food.CaloriesPer100Grams;
                totalCarbs += foodCarbs;
            }
            return totalCarbs;

        }

        public string CalculateNeededInsulin(DateTime eatTime, double currentBloodGlucose, double insulinSensibility)
        {
            var totalCarbs = this.GetBeuFromCarbohydrate();
            double neededInsulin = 0;
            double dayPartInsulinRatio = this.GetdayPartInsulinRatio(eatTime);
            neededInsulin = (totalCarbs / 12) * dayPartInsulinRatio;
            var message = string.Empty;

            if (currentBloodGlucose >= 7.5)
            {
                int minutesWait = this.GetMinutestWait(eatTime);
                double correctInsulin = this.GetCorrectInsulin(currentBloodGlucose, insulinSensibility);
                neededInsulin += correctInsulin;
                message = string.Format($"You need to wait at least {minutesWait} minutes before eat! Needed insulin is {this.RoundInsulinDosage(neededInsulin)}");
            }
            else if (currentBloodGlucose < 7.5 && currentBloodGlucose >= 4.5)
            {
                message = string.Format($"Needed insulin is {this.RoundInsulinDosage(neededInsulin)}");
            }
            else
            {
                message = string.Format($"You need to eat before insulin! Needed insulin is {this.RoundInsulinDosage(neededInsulin)}");
            }

            return message;
        }

        public async Task AddCarbohydrateIntakeAsync(AddNewCarbohydtrateIntakeViewModel input)
        {
            var carbohydrateIntake = new CarbohydrateIntake
            {
                Date = input.Date,
                UserName = input.AddedByUser,
                FoodName=input.FoodName,

            };

                await this.carbsRepository.AddAsync(carbohydrateIntake);
                await this.carbsRepository.SaveChangesAsync();
            
        }

        private int GetMinutestWait(DateTime eatTime)
        {
            int minutesWait = 30;

            if (eatTime.Hour > 6 && eatTime.Hour <= 11)
            {
                minutesWait += 15;
            }
            else if (eatTime.Hour > 14 && eatTime.Hour <= 17)
            {
                minutesWait -= 10;
            }

            return minutesWait;
        }

        private double GetCorrectInsulin(double currentBloodGlucose, double insulinSensibility)
        {
            double correctInsulin = 0;
            return correctInsulin = (currentBloodGlucose - 7.5) / insulinSensibility;
        }

        private double GetdayPartInsulinRatio(DateTime hour)
        {
            double dayPartInsulinRatio = 0;

            if (hour.Hour > 6 && hour.Hour <= 11)
            {
                dayPartInsulinRatio = 1.25;
            }
            else if (hour.Hour > 11 && hour.Hour <= 14)
            {
                dayPartInsulinRatio = 0.90;
            }
            else if (hour.Hour > 14 && hour.Hour <= 17)
            {
                dayPartInsulinRatio = 0.70;
            }
            else if (hour.Hour > 17 && hour.Hour <= 21)
            {
                dayPartInsulinRatio = 0.85;
            }
            else
            {
                dayPartInsulinRatio = 1;
            }

            return dayPartInsulinRatio;
        }

        private double RoundInsulinDosage(double neededInsulin)
        {
            return Math.Round(neededInsulin * 2, MidpointRounding.AwayFromZero) / 2;
        }
    }
}
