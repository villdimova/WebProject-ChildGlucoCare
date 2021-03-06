namespace ChildGlucoCare.Services.Data.Contracts
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Data.Models;
    using ChildGlucoCare.Web.ViewModels.Foods;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public interface IFoodsService
    {
        Task<Food> CreateAsync(FoodsDto foodsDto);

        public Task<T> GetFoodAsync<T>(int foodId);

        public List<Food> GetAllFoods([FromQuery] AllFoodsViewModel query);

        public Task<Food> DeleteFoodAsync(int foodId);

        public Task<Food> EditFoodAsync(EditFoodInputModel inputModel);

        IEnumerable<SelectListItem> GetAllNames();

        List<string> GetNames();
    }
}
