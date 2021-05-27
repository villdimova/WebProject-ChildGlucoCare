namespace ChildGlucoCare.Services.Data
{
    using System.Threading.Tasks;

    using ChildGlucoCare.Web.ViewModels.InsulinInjections;

    public interface IInsulinInjectionsService
    {
        Task AddAsync(AddNewInsulinInjectionViewModel insulinInjectionViewModel);
    }
}
