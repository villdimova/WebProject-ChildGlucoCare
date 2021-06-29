namespace ChildGlucoCare.Services.Data.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Data.Models;
    using ChildGlucoCare.Web.ViewModels.Foods;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public interface IFoodsService
    {
        Task CreateAsync(FoodsDto foodsDto);

        IEnumerable<SelectListItem> GetAllNames();

        IEnumerable<Food> GetNames();
    }
}
