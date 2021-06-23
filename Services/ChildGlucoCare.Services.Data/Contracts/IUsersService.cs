using ChildGlucoCare.Data.Models;
using System.Threading.Tasks;

namespace ChildGlucoCare.Services.Data.Contracts
{
    public interface IUsersService
    {
        public Task<ApplicationUser> GetUserByIdAsync(string id);

     
    }
}
