namespace ChildGlucoCare.Services.Data.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ChildGlucoCare.Web.ViewModels.InsulinInjections;

    public interface IInsulinInjectionsService
    {
        Task AddAsync(AddNewInsulinInjectionViewModel insulinInjectionViewModel, string userId);
    }
}
