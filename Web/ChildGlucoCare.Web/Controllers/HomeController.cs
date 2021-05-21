namespace ChildGlucoCare.Web.Controllers
{
    using System.Diagnostics;
    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Web.ViewModels;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly IDeletableEntityRepository<Food> foodsRepository;

        public HomeController(

                                                IDeletableEntityRepository<Food> foodsRepository)
        {

            this.foodsRepository = foodsRepository;
        }

        public IActionResult Index()
        {

            return this.View();
        }

        public IActionResult About()
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
