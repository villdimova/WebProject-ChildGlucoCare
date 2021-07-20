namespace ChildGlucoCare.Services.Data.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Web.ViewModels.SportActivities;

    public interface ISportActivityService
    {
        Task AddAsync(AddSportActivityViewModel sportActivityViewModel, string userId);

        Task<T> GetSportActivityAsync<T>(int sportActivityId);

        Task<SportActivity> DeleteSportActivityAsync(int sportActivityId);

        Task<SportActivity> EditSportActivityAsync(EditSportActivityInputModel inputModel);

        Task<IEnumerable<T>> GetAll<T>();

    }
}
