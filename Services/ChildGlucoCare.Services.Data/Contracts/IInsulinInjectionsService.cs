namespace ChildGlucoCare.Services.Data.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Web.ViewModels.InsulinInjections;

    public interface IInsulinInjectionsService
    {
        Task AddAsync(AddNewInsulinInjectionViewModel insulinInjectionViewModel, string userId);

        Task<T> GetInsulinInjectionAsync<T>(int insulinInjectionId);

        Task<InsulinInjection> DeleteInsulinInjectionAsync(int insulinInjectionId);

        Task<InsulinInjection> EditInsulinInjectionAsync(EditInsulinInjectionInputModel inputModel);

        Task<IEnumerable<T>> GetAll<T>();
    }
}
