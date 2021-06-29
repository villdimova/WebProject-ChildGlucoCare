namespace ChildGlucoCare.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Services.Mapping;

    public class InsulinsService : IInsulinsService
    {
        private readonly IDeletableEntityRepository<Insulin> insulinsRepository;

        public InsulinsService(IDeletableEntityRepository<Insulin> insulinsRepository)
        {
            this.insulinsRepository = insulinsRepository;
        }

        public IEnumerable<T> GetAll<T>()
        {
            var insulins = this.insulinsRepository.AllAsNoTracking()
                 .OrderBy(x => x.InsulinType).To<T>().ToList();

            return insulins;
        }
    }
}
