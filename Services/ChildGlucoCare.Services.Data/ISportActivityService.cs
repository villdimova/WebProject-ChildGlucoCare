namespace ChildGlucoCare.Services.Data
{
    using System.Threading.Tasks;

    using ChildGlucoCare.Web.ViewModels.SportActivities;

    public interface ISportActivityService
    {
        Task AddAsync(AddSportActivityViewModel sportActivityViewModel);
    }
}
