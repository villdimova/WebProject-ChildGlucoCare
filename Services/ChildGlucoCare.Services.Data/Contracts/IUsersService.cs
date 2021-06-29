namespace ChildGlucoCare.Services.Data.Contracts
{
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Models;

    public interface IUsersService
    {
        public Task<ApplicationUser> GetUserByIdAsync(string id);
    }
}
