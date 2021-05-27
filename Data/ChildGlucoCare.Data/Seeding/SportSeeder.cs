namespace ChildGlucoCare.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Models;

    public class SportSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Sports.Any())
            {
                return;
            }

            await dbContext.Sports.AddAsync(new Sport
            {
                SportName = "Running",
                ActivityLevel = Models.Enums.ActivityLevel.High,
            });
            await dbContext.Sports.AddAsync(new Sport
            {
                SportName = "Swimming",
                ActivityLevel = Models.Enums.ActivityLevel.High,
            });
            await dbContext.Sports.AddAsync(new Sport
            {
                SportName = "Bicycle riding",
                ActivityLevel = Models.Enums.ActivityLevel.Medium,
            });
            await dbContext.Sports.AddAsync(new Sport
            {
                SportName = "Scooter riding",
                ActivityLevel = Models.Enums.ActivityLevel.Low,
            });
            await dbContext.Sports.AddAsync(new Sport
            {
                SportName = "Soccer",
                ActivityLevel = Models.Enums.ActivityLevel.High,
            });
            await dbContext.Sports.AddAsync(new Sport
            {
                SportName = "Gymnastics",
                ActivityLevel = Models.Enums.ActivityLevel.High,
            });
            await dbContext.Sports.AddAsync(new Sport
            {
                SportName = "Tennis",
                ActivityLevel = Models.Enums.ActivityLevel.High,
            });
            await dbContext.Sports.AddAsync(new Sport
            {
                SportName = "Dancing",
                ActivityLevel = Models.Enums.ActivityLevel.Medium,
            });
            await dbContext.Sports.AddAsync(new Sport
            {
                SportName = "Hiking",
                ActivityLevel = Models.Enums.ActivityLevel.Medium,
            });
            await dbContext.Sports.AddAsync(new Sport
            {
                SportName = "Skiing",
                ActivityLevel = Models.Enums.ActivityLevel.High,
            });
            await dbContext.Sports.AddAsync(new Sport
            {
                SportName = "Martial Arts",
                ActivityLevel = Models.Enums.ActivityLevel.High,
            });
            await dbContext.Sports.AddAsync(new Sport
            {
                SportName = "Jumping Rope",
                ActivityLevel = Models.Enums.ActivityLevel.Medium,
            });
            await dbContext.Sports.AddAsync(new Sport
            {
                SportName = "Roller blading",
                ActivityLevel = Models.Enums.ActivityLevel.Medium,
            });
            await dbContext.Sports.AddAsync(new Sport
            {
                SportName = "Basketball",
                ActivityLevel = Models.Enums.ActivityLevel.High,
            });
            await dbContext.Sports.AddAsync(new Sport
            {
                SportName = "Volleyball",
                ActivityLevel = Models.Enums.ActivityLevel.High,
            });
            await dbContext.Sports.AddAsync(new Sport
            {
                SportName = "Walk",
                ActivityLevel = Models.Enums.ActivityLevel.Low,
            });
            await dbContext.Sports.AddAsync(new Sport
            {
                SportName = "Play outside",
                ActivityLevel = Models.Enums.ActivityLevel.Low,
            });

            await dbContext.SaveChangesAsync();
        }
    }
}
