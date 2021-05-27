using ChildGlucoCare.Data.Common.Repositories;
using ChildGlucoCare.Data.Models;
using ChildGlucoCare.Web.ViewModels.InsulinInjections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildGlucoCare.Services.Data
{
    public class InsulinInjectionService : IInsulinInjectionsService
    {
        private readonly IDeletableEntityRepository<InsulinInjection> injectionRepository;
        private readonly IDeletableEntityRepository<Insulin> insulinsRepository;

        public InsulinInjectionService(IDeletableEntityRepository<InsulinInjection> injectionRepository,
                                                        IDeletableEntityRepository<Insulin> insulinsRepository)
        {
            this.injectionRepository = injectionRepository;
            this.insulinsRepository = insulinsRepository;
        }

        public async Task AddAsync(AddNewInsulinInjectionViewModel input)
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
                IsItForMeal = input.IsItForMeal,
                UserName = input.UserName,
            };

            await this.injectionRepository.AddAsync(insulinInjection);
            await this.insulinsRepository.SaveChangesAsync();
        }
    }
}
