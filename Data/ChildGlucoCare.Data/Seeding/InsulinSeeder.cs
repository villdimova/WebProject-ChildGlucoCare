namespace ChildGlucoCare.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Models;

    public class InsulinSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Insulins.Any())
            {
                return;
            }

            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "NovoRapid",
                InsulinType = Models.Enums.InsulinType.RapidActingAnalogue,
                Onset = "10-20 mins",
                Peak = "1-3 hours",
                Duration = "2-5 hours",
                Taken = "Just before,with or just after food",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "Humalog",
                InsulinType = Models.Enums.InsulinType.RapidActingAnalogue,
                Onset = "10-20 mins",
                Peak = "1-3 hours",
                Duration = "2-5 hours",
                Taken = "Just before,with or just after food",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "Apidra",
                InsulinType = Models.Enums.InsulinType.RapidActingAnalogue,
                Onset = "10-20 mins",
                Peak = "1-3 hours",
                Duration = "2-5 hours",
                Taken = "Just before,with or just after food",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "Actrapid",
                InsulinType = Models.Enums.InsulinType.ShortActing,
                Onset = "30-60 mins",
                Peak = "1-5 hours",
                Duration = "5-9 hours",
                Taken = "15-30 mins before food",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "HumulinS",
                InsulinType = Models.Enums.InsulinType.ShortActing,
                Onset = "30-60 mins",
                Peak = "1-5 hours",
                Duration = "5-9 hours",
                Taken = "15-30 mins before food",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "InsumanRapid",
                InsulinType = Models.Enums.InsulinType.ShortActing,
                Onset = "30-60 mins",
                Peak = "1-5 hours",
                Duration = "5-9 hours",
                Taken = "15-30 mins before food",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "HypurinBovineNeutral",
                InsulinType = Models.Enums.InsulinType.ShortActing,
                Onset = "30-60 mins",
                Peak = "1-5 hours",
                Duration = "5-9 hours",
                Taken = "15-30 mins before food",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "HypurinePorcineNeutral",
                InsulinType = Models.Enums.InsulinType.ShortActing,
                Onset = "30-60 mins",
                Peak = "1-5 hours",
                Duration = "5-9 hours",
                Taken = "15-30 mins before food",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "HypurinBovineIsophane",
                InsulinType = Models.Enums.InsulinType.IntermediateActing,
                Onset = "60-90 mins",
                Peak = "2-12 hrs",
                Duration = "12-24 hrs",
                Taken = "About 30 mins before food or bedtime",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "HypurinPorcineIsophane",
                InsulinType = Models.Enums.InsulinType.IntermediateActing,
                Onset = "60-90 mins",
                Peak = "2-12 hrs",
                Duration = "12-24 hrs",
                Taken = "About 30 mins before food or bedtime",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "Insulatard",
                InsulinType = Models.Enums.InsulinType.IntermediateActing,
                Onset = "60-90 mins",
                Peak = "2-12 hrs",
                Duration = "12-24 hrs",
                Taken = "About 30 mins before food or bedtime",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "HumulinI",
                InsulinType = Models.Enums.InsulinType.IntermediateActing,
                Onset = "60-90 mins",
                Peak = "2-12 hrs",
                Duration = "12-24 hrs",
                Taken = "About 30 mins before food or bedtime",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "InsumanBasal",
                InsulinType = Models.Enums.InsulinType.IntermediateActing,
                Onset = "60-90 mins",
                Peak = "2-12 hrs",
                Duration = "12-24 hrs",
                Taken = "About 30 mins before food or bedtime",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "Levemir",
                InsulinType = Models.Enums.InsulinType.LongActingAnalogue,
                Onset = "2-4 hrs",
                Peak = "6-14 hrs",
                Duration = "16-20 hrs",
                Taken = "Once or twice a day",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "Lantus",
                InsulinType = Models.Enums.InsulinType.LongActingAnalogue,
                Onset = "2-4 hrs",
                Peak = "No peak",
                Duration = "20-24 hrs",
                Taken = "Once or twice a day",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "Tresiba",
                InsulinType = Models.Enums.InsulinType.LongActingAnalogue,
                Onset = "30-90 mins",
                Peak = "No peak",
                Duration = "Over 42 hours",
                Taken = "Once a day",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "NovoMix",
                InsulinType = Models.Enums.InsulinType.MixedInsulinsBiphasic,
                Onset = "10-20 mins",
                Peak = "1-4 hours",
                Duration = "Up to 24 hours",
                Taken = "Just before with or just after food",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "HumalogMix25",
                InsulinType = Models.Enums.InsulinType.MixedInsulinsBiphasic,
                Onset = "10-20 mins",
                Peak = "1-4 hours",
                Duration = "Up to 24 hours",
                Taken = "Just before with or just after food",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "HumalogMix50",
                InsulinType = Models.Enums.InsulinType.MixedInsulinsBiphasic,
                Onset = "10-20 mins",
                Peak = "1-4 hours",
                Duration = "Up to 24 hours",
                Taken = "Just before with or just after food",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "HypurinProcine30/70Mix",
                InsulinType = Models.Enums.InsulinType.MixedInsulinsBiphasic,
                Onset = "30 mins",
                Peak = "1-4 hrs",
                Duration = "12-24 hrs",
                Taken = "15-30 mins before food",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "HumulinM3",
                InsulinType = Models.Enums.InsulinType.MixedInsulinsBiphasic,
                Onset = "30 mins",
                Peak = "1-4 hrs",
                Duration = "12-24 hrs",
                Taken = "15-30 mins before food",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "InsumanComb15",
                InsulinType = Models.Enums.InsulinType.MixedInsulinsBiphasic,
                Onset = "30 mins",
                Peak = "1-4 hrs",
                Duration = "12-24 hrs",
                Taken = "15-30 mins before food",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "InsumanComb30",
                InsulinType = Models.Enums.InsulinType.MixedInsulinsBiphasic,
                Onset = "30 mins",
                Peak = "1-4 hrs",
                Duration = "12-24 hrs",
                Taken = "15-30 mins before food",
            });
            await dbContext.Insulins.AddAsync(new Insulin
            {
                Name = "InsumanComb50",
                InsulinType = Models.Enums.InsulinType.MixedInsulinsBiphasic,
                Onset = "30 mins",
                Peak = "1-4 hrs",
                Duration = "12-24 hrs",
                Taken = "15-30 mins before food",
            });

            await dbContext.SaveChangesAsync();
        }
    }
}
