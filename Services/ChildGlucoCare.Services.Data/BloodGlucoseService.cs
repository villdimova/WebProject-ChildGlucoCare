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
    using Microsoft.EntityFrameworkCore;

    public class BloodGlucoseService : IBloodGlucoseService
    {
        private readonly IDeletableEntityRepository<BloodGlucose> bloodGlucoseRepository;

        public BloodGlucoseService(
                                                       IDeletableEntityRepository<BloodGlucose> bloodGlucoseRepository)
        {
            this.bloodGlucoseRepository = bloodGlucoseRepository;
        }

        public async Task AddBloodGlucoseAsync(AddBloodGlucoseInputModel bloodGlucoseViewModel, ApplicationUser user)
        {
            var bloodGlucose = new BloodGlucose
            {
                CurrentGlucoseLevel = bloodGlucoseViewModel.CurrentGlucoseLevel,
                Date = bloodGlucoseViewModel.Date,
                ApplicationUser = user,
            };

            bloodGlucose.BloodGlocoseStatus = this.GetBloodGlucoseStatus(bloodGlucose);

            if (bloodGlucose.BloodGlocoseStatus != BloodGlocoseStatus.High)
            {
                bloodGlucose.SuggestedCorrectionDoseInsulin = 0;
            }
            else
            {
                bloodGlucose.SuggestedCorrectionDoseInsulin = this.CalculateProperInsulinDose(bloodGlucoseViewModel, user);
            }

            await this.bloodGlucoseRepository.AddAsync(bloodGlucose);
            await this.bloodGlucoseRepository.SaveChangesAsync();
        }

        public double CalculateProperInsulinDose(BloodGlucoseInputModel bloodGlucoseViewModel, ApplicationUser user)
        {
            var insulinSensitivity = user.InsulinSensitivity;
            var currentBloodGlucose = bloodGlucoseViewModel.CurrentGlucoseLevel;

            var correctInsulin = (currentBloodGlucose - 6) / insulinSensitivity;

            return Math.Round(correctInsulin * 2, MidpointRounding.AwayFromZero) / 2;
        }

        public BloodGlucose LastAddedBloodGlucose()
        {
            var lastBloodGlucose = this.bloodGlucoseRepository.AllAsNoTracking()
                .OrderByDescending(x => x.Id)
                .FirstOrDefault(x => x.BloodGlocoseStatus == BloodGlocoseStatus.High);

            return lastBloodGlucose;
        }

        public async Task<IEnumerable<T>> GetAll<T>()
        {
            return await this.bloodGlucoseRepository
                .All()
                .OrderByDescending(x => x.Date)
                .To<T>()
                .ToListAsync();
        }

        public async Task<T> GetBloodGlucoseAsync<T>(int bloodGlucoseId)
        {
            return await this.bloodGlucoseRepository
              .All()
              .Where(x => x.Id == bloodGlucoseId)
              .To<T>()
              .FirstOrDefaultAsync();
        }

        public async Task<BloodGlucose> DeleteBloodGlucoseAsync(int bloodGlucoseId)
        {
            var bloodGlucose = await this.bloodGlucoseRepository
                .All()
                .FirstOrDefaultAsync(x => x.Id == bloodGlucoseId);

            this.bloodGlucoseRepository.Delete(bloodGlucose);
            await this.bloodGlucoseRepository.SaveChangesAsync();

            return bloodGlucose;
        }

        public async Task<BloodGlucose> EditBloodGlucoseAsync(EditBloodGlucoseInputModel inputModel, ApplicationUser user)
        {
            var bloodGlucose = await this.bloodGlucoseRepository
                            .All().FirstOrDefaultAsync(x => x.Id == inputModel.Id);

            bloodGlucose.CurrentGlucoseLevel = inputModel.CurrentGlucoseLevel;
            bloodGlucose.BloodGlocoseStatus = this.GetBloodGlucoseStatus(bloodGlucose);

            if (bloodGlucose.BloodGlocoseStatus != BloodGlocoseStatus.High)
            {
                bloodGlucose.SuggestedCorrectionDoseInsulin = 0;
            }
            else
            {
                bloodGlucose.SuggestedCorrectionDoseInsulin = this.CalculateProperInsulinDose(inputModel, user);
            }

            await this.bloodGlucoseRepository.SaveChangesAsync();
            return bloodGlucose;
        }

        private BloodGlocoseStatus GetBloodGlucoseStatus(BloodGlucose bloodGlucose)
        {
            BloodGlocoseStatus bloodGlucoseStatus = BloodGlocoseStatus.None;

            if (bloodGlucose.CurrentGlucoseLevel <= 4)
            {
                bloodGlucoseStatus = BloodGlocoseStatus.Low;
            }
            else if (bloodGlucose.CurrentGlucoseLevel > 4 && bloodGlucose.CurrentGlucoseLevel < 7.5)
            {
                bloodGlucoseStatus = BloodGlocoseStatus.Normal;
            }
            else
            {
                bloodGlucoseStatus = BloodGlocoseStatus.High;
            }

            return bloodGlucoseStatus;
        }
    }
}
