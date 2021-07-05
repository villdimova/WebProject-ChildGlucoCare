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
    using ChildGlucoCare.Web.ViewModels.Insulins;
    using Microsoft.EntityFrameworkCore;

    public class InsulinsService : IInsulinsService
    {
        private readonly IDeletableEntityRepository<Insulin> insulinsRepository;

        public InsulinsService(IDeletableEntityRepository<Insulin> insulinsRepository)
        {
            this.insulinsRepository = insulinsRepository;
        }

        public async Task<Insulin> CreateAsync(CreateInsulinInputModel input)
        {
            var insulin = new Insulin
            {
                Name = input.Name,
                InsulinType = input.InsulinType,
                Taken = input.Taken,
                Onset = input.Onset,
                Peak = input.Peak,
                Duration = input.Duration,
            };

            await this.insulinsRepository.AddAsync(insulin);
            await this.insulinsRepository.SaveChangesAsync();

            return insulin;
        }

        public async Task<Insulin> DeleteInsulinAsync(int insulinId)
        {
            var insulin = await this.insulinsRepository
                 .All()
                 .FirstOrDefaultAsync(x => x.Id == insulinId);

            this.insulinsRepository.Delete(insulin);
            await this.insulinsRepository.SaveChangesAsync();

            return insulin;
        }

        public async Task<Insulin> EditInsulinAsync(EditInsulinInputModel inputModel)
        {
            var insulin = await this.insulinsRepository
                 .All().FirstOrDefaultAsync(x => x.Id == inputModel.Id);

            insulin.Name = inputModel.Name;
            insulin.Taken = inputModel.Taken;
            insulin.Onset = inputModel.Onset;
            insulin.Peak = inputModel.Peak;
            insulin.Duration = inputModel.Duration;

            await this.insulinsRepository.SaveChangesAsync();
            return insulin;
        }

        public async Task<T> GetInsulinAsync<T>(int insulinId)
        {
            return await this.insulinsRepository
             .All()
             .Where(x => x.Id == insulinId)
             .To<T>()
             .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetAll<T>()
        {
            return await this.insulinsRepository
                      .All()
                      .OrderBy(f => f.Name)
                      .To<T>()
                      .ToListAsync();
        }
    }
}
