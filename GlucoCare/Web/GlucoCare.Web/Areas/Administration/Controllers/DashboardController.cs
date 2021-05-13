namespace GlucoCare.Web.Areas.Administration.Controllers
{
   
    using GlucoCare.Web.ViewModels.Administration.Dashboard;

    using Microsoft.AspNetCore.Mvc;

    public class DashboardController : AdministrationController
    {
      

        public IActionResult Index()
        {
            return this.View();
        }
    }
}
