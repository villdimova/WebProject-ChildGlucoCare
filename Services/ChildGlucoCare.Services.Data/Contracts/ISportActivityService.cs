namespace ChildGlucoCare.Services.Data.Contracts
{
    using System.Threading.Tasks;

    using ChildGlucoCare.Web.ViewModels.SportActivities;

    public interface ISportActivityService
    {
        Task AddAsync(AddSportActivityViewModel sportActivityViewModel,string userId);
    }
}
