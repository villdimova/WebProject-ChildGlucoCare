namespace ChildGlucoCare.Data.Seeding
{
    using System;
    using System.Threading.Tasks;

    public interface ISeeder
    {
        Task SeedAsync(ChildGlucoCareDbContext dbContext, IServiceProvider serviceProvider);
    }
}
