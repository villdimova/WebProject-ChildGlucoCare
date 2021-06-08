namespace ChildGlucoCare.Web.Controllers
{
    using System.Diagnostics;
    using System.Threading.Tasks;
    using ChildGlucoCare.Data.Common.Repositories;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Web.ViewModels;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IDeletableEntityRepository<Food> foodsRepository;

        public HomeController(
                                                UserManager<ApplicationUser> userManager,
                                                IDeletableEntityRepository<Food> foodsRepository)
        {
            this.userManager = userManager;
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

        public async Task<IActionResult> WhoAmI()
        {
           var user=  await this.userManager.GetUserAsync(this.User);
            return this.Json(user);
        }
    }
}
