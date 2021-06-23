using ChildGlucoCare.Data.Common.Repositories;
using ChildGlucoCare.Data.Models;
using ChildGlucoCare.Services.Data.Contracts;
using Microsoft.EntityFrameworkCore;

using System.Threading.Tasks;

namespace ChildGlucoCare.Services.Data
{
    public class UsersService : IUsersService
    {
        private readonly IDeletableEntityRepository<ApplicationUser> userRepository;

        public UsersService(IDeletableEntityRepository<ApplicationUser> userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<ApplicationUser> GetUserByIdAsync(string id)
        {
            return await this.userRepository
                .All()
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
