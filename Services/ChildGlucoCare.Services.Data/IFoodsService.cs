namespace ChildGlucoCare.Services.Data
{
    using System.Threading.Tasks;

    using ChildGlucoCare.Services.Data.Models;
    using ChildGlucoCare.Web.ViewModels.Foods;

    public interface IFoodsService
    {
        Task CreateAsync(FoodsDto foodsDto);

    }
}