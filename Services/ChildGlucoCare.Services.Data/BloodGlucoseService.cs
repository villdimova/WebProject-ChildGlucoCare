namespace ChildGlucoCare.Services.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Data.Models.Enums;
    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Web.ViewModels.BloodGlucoses;

    public class BloodGlucoseService : IBloodGlucoseService
    {
        private readonly IDeletableEntityRepository<BloodGlucose> bloodGlucoseRepository;
        private readonly IUsersService userService;

        public BloodGlucoseService(IDeletableEntityRepository<BloodGlucose> bloodGlucoseRepository
                                                      ,IUsersService userService)
        {
            this.bloodGlucoseRepository = bloodGlucoseRepository;
            this.userService = userService;
        }

        public async Task AddBloodGlucoseAsync(AddBloodGlucoseViewModel bloodGlucoseViewModel,string userId)
        {
            var bloodGlucose = new BloodGlucose
            {
                CurrentGlucoseLevel = bloodGlucoseViewModel.CurrentGlucoseLevel,
                Date = bloodGlucoseViewModel.Date,
                ApplicationUser = await this.userService.GetUserByIdAsync(userId),

            };

            if (bloodGlucose.CurrentGlucoseLevel <= 4)
            {
                bloodGlucose.BloodGlocoseStatus = BloodGlocoseStatus.Low;
            }
            else if (bloodGlucose.CurrentGlucoseLevel > 4 && bloodGlucose.CurrentGlucoseLevel < 7.5)
            {
                bloodGlucose.BloodGlocoseStatus = BloodGlocoseStatus.Normal;
            }
            else
            {
                bloodGlucose.BloodGlocoseStatus = BloodGlocoseStatus.High;
            }

            if (bloodGlucose.BloodGlocoseStatus != BloodGlocoseStatus.High)
            {
                bloodGlucose.SuggestedCorrectionDoseInsulin = 0;
            }
            else
            {
                bloodGlucose.SuggestedCorrectionDoseInsulin = CalculateProperInsulinDose(bloodGlucoseViewModel);

            }

            await this.bloodGlucoseRepository.AddAsync(bloodGlucose);
            await this.bloodGlucoseRepository.SaveChangesAsync();
        }

        public double CalculateProperInsulinDose(AddBloodGlucoseViewModel bloodGlucoseViewModel)
        {
            var insulinSensitivity = bloodGlucoseViewModel.InsulinSensitivity;
            var currentBloodGlucose = bloodGlucoseViewModel.CurrentGlucoseLevel;

            double correctInsulin = 0;
            correctInsulin = (currentBloodGlucose - 6) / insulinSensitivity;

            return Math.Round(correctInsulin * 2, MidpointRounding.AwayFromZero) / 2;
        }

        public BloodGlucose LastAddedBloodGlucose()
        {
            var lastBloodGlucose = this.bloodGlucoseRepository.AllAsNoTracking()
                .OrderByDescending(x => x.Id)
                .FirstOrDefault(x => x.BloodGlocoseStatus == BloodGlocoseStatus.High);

            return lastBloodGlucose;
        }
    }
}
