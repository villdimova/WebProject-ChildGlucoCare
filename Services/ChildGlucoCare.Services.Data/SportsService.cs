namespace ChildGlucoCare.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Data.Contracts;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class SportsService : ISportsService
    {
        private readonly IDeletableEntityRepository<Sport> sportsRepository;

        public SportsService(IDeletableEntityRepository<Sport> sportsRepository)
        {
            this.sportsRepository = sportsRepository;
        }

        public IEnumerable<SelectListItem> GetAllNames()
        {
            var sportsNames = this.sportsRepository.AllAsNoTracking().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.SportName,
            });

            return sportsNames.OrderBy(x => x.Text).ToList();
        }
    }
}
