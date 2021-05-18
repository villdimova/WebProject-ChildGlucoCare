namespace ChildGlucoCare.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;
    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Web.ViewModels;
    using ChildGlucoCare.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly IDeletableEntityRepository<DiabeticDiary> diabeticDiariesRepository;
        private readonly IDeletableEntityRepository<Food> foodsRepository;

        public HomeController(
                                                IDeletableEntityRepository<DiabeticDiary> diabeticDiariesRepository,
                                                IDeletableEntityRepository<Food> foodsRepository)
        {
            this.diabeticDiariesRepository = diabeticDiariesRepository;
            this.foodsRepository = foodsRepository;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel
            {
                DiabeticDiariesCount = this.diabeticDiariesRepository.All().Count(),
                FoodsCount = this.foodsRepository.All().Count(),
            };
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
