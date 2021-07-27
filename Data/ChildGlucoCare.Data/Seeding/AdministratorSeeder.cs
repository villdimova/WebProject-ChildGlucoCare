namespace ChildGlucoCare.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using ChildGlucoCare.Common;
    using ChildGlucoCare.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;

    public class AdministratorSeeder : ISeeder
    {
        private static string adminPass = "Admin123";

        public async Task SeedAsync(ChildGlucoCareDbContext dbContext, IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            var user = new ApplicationUser
            {
                Email = "admin@cgc.com",
                UserName = "admin@cgc.com",
                FirstName = "Vill",
                LastName = "Dimova",
            };

            await userManager.CreateAsync(user, adminPass);
            await userManager.AddToRoleAsync(user,GlobalConstants.AdministratorRoleName);
        }
    }
}
