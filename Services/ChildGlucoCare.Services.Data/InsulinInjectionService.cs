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
            var injectedInulin = this.insulinsRepository.All().FirstOrDefault(i => i.Name == input.InsulinName);

            if (injectedInulin == null)
            {
                throw new ArgumentOutOfRangeException();
            }

            var insulinInjection = new InsulinInjection
            {
                Date = input.Date,
                Insulin = injectedInulin,
                InsulinDose = input.InsulinDose,
                TotalMealBeu = input.TotalBeu,
                CurrentGlucoselevel = input.CurrentGlucoseLevel,
                ApplicationUser = await this.userService.GetUserByIdAsync(userId),
            };

            await this.injectionRepository.AddAsync(insulinInjection);
            await this.insulinsRepository.SaveChangesAsync();
        }
    }
}
