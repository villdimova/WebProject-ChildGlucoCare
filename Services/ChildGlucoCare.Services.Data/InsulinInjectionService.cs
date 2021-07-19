namespace ChildGlucoCare.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Services.Mapping;
    using ChildGlucoCare.Web.ViewModels.InsulinInjections;
    using Microsoft.EntityFrameworkCore;

    public class InsulinInjectionService : IInsulinInjectionsService
    {
        private readonly IDeletableEntityRepository<InsulinInjection> injectionRepository;
        private readonly IDeletableEntityRepository<Insulin> insulinsRepository;
        private readonly IUsersService userService;

        public InsulinInjectionService(
                                                        IDeletableEntityRepository<InsulinInjection> injectionRepository,
                                                        IDeletableEntityRepository<Insulin> insulinsRepository,
                                                        IUsersService userService)
        {
            this.injectionRepository = injectionRepository;
            this.insulinsRepository = insulinsRepository;
            this.userService = userService;
        }

        public async Task AddAsync(AddNewInsulinInjectionViewModel input, string userId)
        {
            var injectedInsulin = this.insulinsRepository.All().FirstOrDefault(i => i.Id.ToString() == input.InsulinName);

            var insulinInjection = new InsulinInjection
            {
                Date = input.Date,
                Insulin = injectedInsulin,
                InsulinDose = input.InsulinDose,
                TotalMealBeu = input.TotalBeu,
                CurrentGlucoselevel = input.CurrentGlucoseLevel,
                ApplicationUser = await this.userService.GetUserByIdAsync(userId),
            };

            await this.injectionRepository.AddAsync(insulinInjection);
            await this.insulinsRepository.SaveChangesAsync();
        }

        public async Task<InsulinInjection> DeleteInsulinInjectionAsync(int insulinInjectionId)
        {
            var injection = await this.injectionRepository
                .All()
                .FirstOrDefaultAsync(x => x.Id == insulinInjectionId);

            this.injectionRepository.Delete(injection);
            await this.injectionRepository.SaveChangesAsync();

            return injection;
        }

        public async Task<InsulinInjection> EditInsulinInjectionAsync(EditInsulinInjectionInputModel inputModel)
        {
            var injectedInsulin = this.insulinsRepository.All().FirstOrDefault(i => i.Id.ToString() == inputModel.InsulinName);
            var injection = await this.injectionRepository
                             .All().FirstOrDefaultAsync(x => x.Id == inputModel.Id);

            injection.Date = inputModel.Date;
            injection.CurrentGlucoselevel = inputModel.CurrentGlucoseLevel;
            injection.InsulinDose = inputModel.InsulinDose;
            injection.TotalMealBeu = inputModel.TotalBeu;
            injection.Insulin = injectedInsulin;

            await this.injectionRepository.SaveChangesAsync();
            return injection;
        }

        public async Task<IEnumerable<T>> GetAll<T>()
        {
            return await this.injectionRepository
              .All()
              .OrderByDescending(x => x.Date)
              .To<T>()
              .ToListAsync();
        }

        public async Task<T> GetInsulinInjectionAsync<T>(int insulinInjectionId)
        {
            return await this.injectionRepository
              .All()
              .Where(x => x.Id == insulinInjectionId)
              .To<T>()
              .FirstOrDefaultAsync();
        }
    }
}
