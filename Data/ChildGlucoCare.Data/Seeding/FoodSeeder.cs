namespace ChildGlucoCare.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Models;

    public class FoodSeeder : ISeeder
    {
        public async Task SeedAsync(ChildGlucoCareDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Foods.Any())
            {
                return;
            }

            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Whole Grain Bread",
                GramsPerBreadUnit = 30,
                GlycemicIndex = 49,
                CarbohydratePer100Grams = 48,
                FatPer100Grams = 1.6,
                CaloriesPer100Grams = 200,
                FoodType = Models.Enums.FoodType.Grains,
                ImageUrl = "https://bbteamcdn.com/img/food/395372_130.jpg",
            });

            await dbContext.Foods.AddAsync(new Food
            {
                Name = "White Bread",
                GramsPerBreadUnit = 25,
                GlycemicIndex = 75,
                CarbohydratePer100Grams = 48,
                FatPer100Grams = 5,
                CaloriesPer100Grams = 240,
                FoodType = Models.Enums.FoodType.Grains,
                ImageUrl = "https://bbteamcdn.com/img/food/855739_130.jpg",
            });

            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Pretzel",
                GramsPerBreadUnit = 20,
                GlycemicIndex = 62,
                CarbohydratePer100Grams = 68,
                FatPer100Grams = 1.30,
                CaloriesPer100Grams = 335,
                FoodType = Models.Enums.FoodType.Grains,
                ImageUrl = "https://bbteamcdn.com/img/food/956017_130.jpg",
            });

            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Soleti",
                GramsPerBreadUnit = 20,
                GlycemicIndex = 70,
                CarbohydratePer100Grams = 68,
                FatPer100Grams = 3.7,
                CaloriesPer100Grams = 380,
                FoodType = Models.Enums.FoodType.Grains,
                ImageUrl = "https://bbteamcdn.com/img/food/361875_130.jpg",
            });

            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Oatmeal",
                GramsPerBreadUnit = 20,
                GlycemicIndex = 56,
                CarbohydratePer100Grams = 60,
                FatPer100Grams = 7.8,
                CaloriesPer100Grams = 362,
                FoodType = Models.Enums.FoodType.Grains,
                ImageUrl = "https://bbteamcdn.com/img/food/538413_130.jpg",
            });

            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Cornflakes",
                GramsPerBreadUnit = 15,
                GlycemicIndex = 83,
                CarbohydratePer100Grams = 83,
                FatPer100Grams = 3.2,
                CaloriesPer100Grams = 385,
                FoodType = Models.Enums.FoodType.Grains,
                ImageUrl = "https://bbteamcdn.com/img/food/867201_130.jpg",
            });

            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Short Grain Rice",
                GramsPerBreadUnit = 50,
                GlycemicIndex = 72,
                CarbohydratePer100Grams = 24,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 336,
                FoodType = Models.Enums.FoodType.Grains,
                ImageUrl = "https://bbteamcdn.com/img/food/407443_130.jpg",
            });

            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Long Grain Rice",
                GramsPerBreadUnit = 50,
                GlycemicIndex = 44,
                CarbohydratePer100Grams = 24,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 55,
                FoodType = Models.Enums.FoodType.Grains,
                ImageUrl = "https://bbteamcdn.com/img/food/646375_130.jpg",
            });

            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Popcorn",
                GramsPerBreadUnit = 20,
                GlycemicIndex = 70,
                CarbohydratePer100Grams = 60,
                FatPer100Grams = 28,
                CaloriesPer100Grams = 518,
                FoodType = Models.Enums.FoodType.Grains,
                ImageUrl = "https://bbteamcdn.com/img/food/915952_130.jpg",
            });

            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Bruschette",
                GramsPerBreadUnit = 20,
                GlycemicIndex = 65,
                CarbohydratePer100Grams = 65,
                FatPer100Grams = 19,
                CaloriesPer100Grams = 466,
                FoodType = Models.Enums.FoodType.Grains,
                ImageUrl = "https://bbteamcdn.com/img/food/495966_130.jpg",
            });

            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Boiled potatos",
                GramsPerBreadUnit = 80,
                GlycemicIndex = 73,
                CarbohydratePer100Grams = 15,
                FatPer100Grams = 0.1,
                CaloriesPer100Grams = 86,
                FoodType = Models.Enums.FoodType.Grains,
                ImageUrl = "https://bbteamcdn.com/img/food/195719_130.jpg",
            });

            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Chips",
                GramsPerBreadUnit = 24,
                GlycemicIndex = 63,
                CarbohydratePer100Grams = 50,
                FatPer100Grams = 30,
                CaloriesPer100Grams = 494,
                FoodType = Models.Enums.FoodType.Grains,
                ImageUrl = "https://bbteamcdn.com/img/food/197997_130.jpg",
            });

            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Pasta",
                GramsPerBreadUnit = 50,
                GlycemicIndex = 40,
                CarbohydratePer100Grams = 24,
                FatPer100Grams = 0.7,
                CaloriesPer100Grams = 126,
                FoodType = Models.Enums.FoodType.Grains,
                ImageUrl = "https://bbteamcdn.com/img/food/350504_130.jpg",
            });

            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Croissant",
                GramsPerBreadUnit = 30,
                GlycemicIndex = 67,
                CarbohydratePer100Grams = 40,
                FatPer100Grams = 21,
                CaloriesPer100Grams = 406,
                FoodType = Models.Enums.FoodType.Grains,
                ImageUrl = "https://bbteamcdn.com/img/food/617313_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Beans",
                GramsPerBreadUnit = 50,
                GlycemicIndex = 29,
                CarbohydratePer100Grams = 22,
                FatPer100Grams = 5.2,
                CaloriesPer100Grams = 155,
                FoodType = Models.Enums.FoodType.Beans,
                ImageUrl = "https://bbteamcdn.com/img/food/214192_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Lentil",
                GramsPerBreadUnit = 50,
                GlycemicIndex = 30,
                CarbohydratePer100Grams = 20,
                FatPer100Grams = 2.3,
                CaloriesPer100Grams = 114,
                FoodType = Models.Enums.FoodType.Beans,
                ImageUrl = "https://bbteamcdn.com/img/food/728379_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Buckwheat",
                GramsPerBreadUnit = 50,
                GlycemicIndex = 49,
                CarbohydratePer100Grams = 25,
                FatPer100Grams = 2.3,
                CaloriesPer100Grams = 139,
                FoodType = Models.Enums.FoodType.Beans,
                ImageUrl = "https://bbteamcdn.com/img/food/839328_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Peas",
                GramsPerBreadUnit = 130,
                GlycemicIndex = 47,
                CarbohydratePer100Grams = 9,
                FatPer100Grams = 2.4,
                CaloriesPer100Grams = 118,
                FoodType = Models.Enums.FoodType.Beans,
                ImageUrl = "https://bbteamcdn.com/img/food/767089_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Boiled Corn",
                GramsPerBreadUnit = 80,
                GlycemicIndex = 60,
                CarbohydratePer100Grams = 15,
                FatPer100Grams = 1.5,
                CaloriesPer100Grams = 88,
                FoodType = Models.Enums.FoodType.Beans,
                ImageUrl = "https://bbteamcdn.com/img/food/876274_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Apple",
                GramsPerBreadUnit = 100,
                GlycemicIndex = 38,
                CarbohydratePer100Grams = 12,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 60,
                FoodType = Models.Enums.FoodType.Fruits,
                ImageUrl = "https://bbteamcdn.com/img/food/374294_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Pear",
                GramsPerBreadUnit = 100,
                GlycemicIndex = 38,
                CarbohydratePer100Grams = 12,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 60,
                FoodType = Models.Enums.FoodType.Fruits,
                ImageUrl = "https://bbteamcdn.com/img/food/958604_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Peach",
                GramsPerBreadUnit = 140,
                GlycemicIndex = 42,
                CarbohydratePer100Grams = 9,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 36,
                FoodType = Models.Enums.FoodType.Fruits,
                ImageUrl = "https://bbteamcdn.com/img/food/225992_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Watermelon",
                GramsPerBreadUnit = 200,
                GlycemicIndex = 76,
                CarbohydratePer100Grams = 6,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 28,
                FoodType = Models.Enums.FoodType.Fruits,
                ImageUrl = "https://bbteamcdn.com/img/food/657579_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Melon",
                GramsPerBreadUnit = 200,
                GlycemicIndex = 65,
                CarbohydratePer100Grams = 6,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 30,
                FoodType = Models.Enums.FoodType.Fruits,
                ImageUrl = "https://bbteamcdn.com/img/food/485622_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Fig",
                GramsPerBreadUnit = 70,
                GlycemicIndex = 61,
                CarbohydratePer100Grams = 17,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 79,
                FoodType = Models.Enums.FoodType.Fruits,
                ImageUrl = "https://bbteamcdn.com/img/food/771484_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Raspberries",
                GramsPerBreadUnit = 170,
                GlycemicIndex = 36,
                CarbohydratePer100Grams = 7,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 38,
                FoodType = Models.Enums.FoodType.Fruits,
                ImageUrl = "https://bbteamcdn.com/img/food/757649_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Strawberries",
                GramsPerBreadUnit = 180,
                GlycemicIndex = 40,
                CarbohydratePer100Grams = 7,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 38,
                FoodType = Models.Enums.FoodType.Fruits,
                ImageUrl = "https://bbteamcdn.com/img/food/843560_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Blackberries",
                GramsPerBreadUnit = 140,
                GlycemicIndex = 34,
                CarbohydratePer100Grams = 9,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 29,
                FoodType = Models.Enums.FoodType.Fruits,
                ImageUrl = "https://bbteamcdn.com/img/food/787136_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Prunes",
                GramsPerBreadUnit = 80,
                GlycemicIndex = 39,
                CarbohydratePer100Grams = 15,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 62,
                FoodType = Models.Enums.FoodType.Fruits,
                ImageUrl = "https://bbteamcdn.com/img/food/406928_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Grapes",
                GramsPerBreadUnit = 70,
                GlycemicIndex = 46,
                CarbohydratePer100Grams = 17,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 62,
                FoodType = Models.Enums.FoodType.Fruits,
                ImageUrl = "https://bbteamcdn.com/img/food/511908_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Banana",
                GramsPerBreadUnit = 60,
                GlycemicIndex = 56,
                CarbohydratePer100Grams = 20,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 92,
                FoodType = Models.Enums.FoodType.Fruits,
                ImageUrl = "https://bbteamcdn.com/img/food/851643_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Apricots",
                GramsPerBreadUnit = 120,
                GlycemicIndex = 57,
                CarbohydratePer100Grams = 10,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 46,
                FoodType = Models.Enums.FoodType.Fruits,
                ImageUrl = "https://bbteamcdn.com/img/food/138997_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Cherries",
                GramsPerBreadUnit = 100,
                GlycemicIndex = 22,
                CarbohydratePer100Grams = 12,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 60,
                FoodType = Models.Enums.FoodType.Fruits,
                ImageUrl = "https://bbteamcdn.com/img/food/728135_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Tangerines",
                GramsPerBreadUnit = 150,
                GlycemicIndex = 45,
                CarbohydratePer100Grams = 8,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 37,
                FoodType = Models.Enums.FoodType.Fruits,
                ImageUrl = "https://bbteamcdn.com/img/food/926839_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Blueberries",
                GramsPerBreadUnit = 90,
                GlycemicIndex = 50,
                CarbohydratePer100Grams = 13,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 61,
                FoodType = Models.Enums.FoodType.Fruits,
                ImageUrl = "https://bbteamcdn.com/img/food/514458_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Orange",
                GramsPerBreadUnit = 130,
                GlycemicIndex = 43,
                CarbohydratePer100Grams = 9,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 42,
                FoodType = Models.Enums.FoodType.Fruits,
                ImageUrl = "https://bbteamcdn.com/img/food/554606_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Grapefruit",
                GramsPerBreadUnit = 150,
                GlycemicIndex = 25,
                CarbohydratePer100Grams = 8,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 33,
                FoodType = Models.Enums.FoodType.Fruits,
                ImageUrl = "https://bbteamcdn.com/img/food/937174_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Kiwi",
                GramsPerBreadUnit = 150,
                GlycemicIndex = 47,
                CarbohydratePer100Grams = 8,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 67,
                FoodType = Models.Enums.FoodType.Fruits,
                ImageUrl = "https://bbteamcdn.com/img/food/995334_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Glucose",
                GramsPerBreadUnit = 12,
                GlycemicIndex = 100,
                CarbohydratePer100Grams = 100,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 417,
                FoodType = Models.Enums.FoodType.QuickSugarFood,
                ImageUrl = "https://bbteamcdn.com/img/food/463808_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Sugar",
                GramsPerBreadUnit = 12,
                GlycemicIndex = 100,
                CarbohydratePer100Grams = 100,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 417,
                FoodType = Models.Enums.FoodType.QuickSugarFood,
                ImageUrl = "https://bbteamcdn.com/img/food/559334_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Honey",
                GramsPerBreadUnit = 12,
                GlycemicIndex = 100,
                CarbohydratePer100Grams = 100,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 417,
                FoodType = Models.Enums.FoodType.QuickSugarFood,
                ImageUrl = "https://bbteamcdn.com/img/food/416586_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Sweet juice",
                GramsPerBreadUnit = 150,
                GlycemicIndex = 78,
                CarbohydratePer100Grams = 8,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 43,
                FoodType = Models.Enums.FoodType.QuickSugarFood,
                ImageUrl = "https://bbteamcdn.com/img/food/524034_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Candy",
                GramsPerBreadUnit = 15,
                GlycemicIndex = 75,
                CarbohydratePer100Grams = 80,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 400,
                FoodType = Models.Enums.FoodType.QuickSugarFood,
                ImageUrl = "https://bbteamcdn.com/img/food/730600_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Chokolate",
                GramsPerBreadUnit = 30,
                GlycemicIndex = 43,
                CarbohydratePer100Grams = 40,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 567,
                FoodType = Models.Enums.FoodType.QuickSugarFood,
                ImageUrl = "https://bbteamcdn.com/img/food/603215_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Jam",
                GramsPerBreadUnit = 25,
                GlycemicIndex = 51,
                CarbohydratePer100Grams = 48,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 220,
                FoodType = Models.Enums.FoodType.QuickSugarFood,
                ImageUrl = "https://bbteamcdn.com/img/food/827787_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Icecream",
                GramsPerBreadUnit = 50,
                GlycemicIndex = 44,
                CarbohydratePer100Grams = 24,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 190,
                FoodType = Models.Enums.FoodType.QuickSugarFood,
                ImageUrl = "https://bbteamcdn.com/img/food/309494_130.jpg",
            });

            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Мilk",
                GramsPerBreadUnit = 250,
                GlycemicIndex = 30,
                CarbohydratePer100Grams = 5,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 66,
                FoodType = Models.Enums.FoodType.Dairy,
                ImageUrl = "https://bbteamcdn.com/img/food/900960_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Yoghurt",
                GramsPerBreadUnit = 240,
                GlycemicIndex = 14,
                CarbohydratePer100Grams = 5,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 49,
                FoodType = Models.Enums.FoodType.Dairy,
                ImageUrl = "https://bbteamcdn.com/img/food/311631_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Fruit yoghurt",
                GramsPerBreadUnit = 100,
                GlycemicIndex = 36,
                CarbohydratePer100Grams = 12,
                FatPer100Grams = 0,
                CaloriesPer100Grams = 100,
                FoodType = Models.Enums.FoodType.Dairy,
                ImageUrl = "https://bbteamcdn.com/img/food/671169_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Beef fillet",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 1.4,
                CaloriesPer100Grams = 95,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/787622_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Beef",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 7.8,
                CaloriesPer100Grams = 157,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/488122_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Pork fillet",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 3.7,
                CaloriesPer100Grams = 118,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/528212_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Pork stack",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 23.03,
                CaloriesPer100Grams = 270,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/565270_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Pork",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 12.5,
                CaloriesPer100Grams = 188,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/598955_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Rabbit",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 8.6,
                CaloriesPer100Grams = 161,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/716232_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Lamb",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 10.3,
                CaloriesPer100Grams = 175,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/163315_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Chicken",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 3.9,
                CaloriesPer100Grams = 124,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/827399_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Hen",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 18.5,
                CaloriesPer100Grams = 218,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/140393_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Goose",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 30.5,
                CaloriesPer100Grams = 332,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/945529_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Duck",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 38.3,
                CaloriesPer100Grams = 404,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/442589_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Turkey",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 12.5,
                CaloriesPer100Grams = 198,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/859001_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Pork liver",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 5.7,
                CaloriesPer100Grams = 137,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/859001_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Chicken livers",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 3.9,
                CaloriesPer100Grams = 121,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/271348_130.jpg",
            });

            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Pork ham",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 17.3,
                CaloriesPer100Grams = 183,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/315293_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Elena fillet",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 4,
                CaloriesPer100Grams = 193,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/237648_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Makedon sausage",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 17.3,
                CaloriesPer100Grams = 202,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/843747_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Beef salami",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 15.6,
                CaloriesPer100Grams = 194,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/811713_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Weenie",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 20.2,
                CaloriesPer100Grams = 217,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/673746_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Pate",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 28,
                CaloriesPer100Grams = 333,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/997775_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Shpek salami",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 39,
                CaloriesPer100Grams = 445,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/594568_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Petrohan salami",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 48,
                CaloriesPer100Grams = 506,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/571298_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Lukanka",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 40,
                CaloriesPer100Grams = 456,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/138712_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Sudjuk",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 29,
                CaloriesPer100Grams = 397,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/625939_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Minced meat-beef 40/pork 60",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 34.3,
                CaloriesPer100Grams = 368,
                FoodType = Models.Enums.FoodType.Meat,
                ImageUrl = "https://bbteamcdn.com/img/food/166483_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Whitefish",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 3,
                CaloriesPer100Grams = 114,
                FoodType = Models.Enums.FoodType.Fish,
                ImageUrl = "https://bbteamcdn.com/img/food/764377_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Sturgeon",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 11,
                CaloriesPer100Grams = 165,
                FoodType = Models.Enums.FoodType.Fish,
                ImageUrl = "https://bbteamcdn.com/img/food/228044_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Trout",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 4.8,
                CaloriesPer100Grams = 132,
                FoodType = Models.Enums.FoodType.Fish,
                ImageUrl = "https://bbteamcdn.com/img/food/758056_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Carp",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 5.8,
                CaloriesPer100Grams = 128,
                FoodType = Models.Enums.FoodType.Fish,
                ImageUrl = "https://bbteamcdn.com/img/food/162841_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Hake",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 2.2,
                CaloriesPer100Grams = 88,
                FoodType = Models.Enums.FoodType.Fish,
                ImageUrl = "https://bbteamcdn.com/img/food/531421_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Mackerel",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 13,
                CaloriesPer100Grams = 192,
                FoodType = Models.Enums.FoodType.Fish,
                ImageUrl = "https://bbteamcdn.com/img/food/990646_130.jpg",
            });

            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Mussels",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 1.5,
                CaloriesPer100Grams = 89,
                FoodType = Models.Enums.FoodType.Fish,
                ImageUrl = "https://bbteamcdn.com/img/food/659885_130.jpg",
            });

            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Salmon",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 22.3,
                CaloriesPer100Grams = 286,
                FoodType = Models.Enums.FoodType.Fish,
                ImageUrl = "https://bbteamcdn.com/img/food/371776_130.jpg",
            });

            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Kashkaval",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 30.7,
                CaloriesPer100Grams = 382,
                FoodType = Models.Enums.FoodType.Dairy,
                ImageUrl = "https://bbteamcdn.com/img/food/570857_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Salamura cheese",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 19.7,
                CaloriesPer100Grams = 269,
                FoodType = Models.Enums.FoodType.Dairy,
                ImageUrl = "https://bbteamcdn.com/img/food/835155_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Dunavia cheese",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 25.3,
                CaloriesPer100Grams = 314,
                FoodType = Models.Enums.FoodType.Dairy,
                ImageUrl = "https://bbteamcdn.com/img/food/948540_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Cottage cheese",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 0.6,
                CaloriesPer100Grams = 58,
                FoodType = Models.Enums.FoodType.Dairy,
                ImageUrl = "https://bbteamcdn.com/img/food/843749_130.jpg",
            });
            await dbContext.Foods.AddAsync(new Food
            {
                Name = "Egg",
                GramsPerBreadUnit = 0,
                GlycemicIndex = 0,
                CarbohydratePer100Grams = 0,
                FatPer100Grams = 10.2,
                CaloriesPer100Grams = 148,
                FoodType = Models.Enums.FoodType.Dairy,
                ImageUrl = "https://bbteamcdn.com/img/food/534966_130.jpg",
            });
            await dbContext.SaveChangesAsync();
        }
    }
}
