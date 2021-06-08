namespace ChildGlucoCare.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Web.ViewModels.InsulinInjections;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class InsulinInjectionsController : Controller
    {
        private readonly IInsulinInjectionsService insulinInjectionService;
        private readonly UserManager<ApplicationUser> userManager;

        public InsulinInjectionsController(
                                                              IInsulinInjectionsService insulinInjectionService,
                                                              UserManager<ApplicationUser>userManager)
        {
            this.insulinInjectionService = insulinInjectionService;
            this.userManager = userManager;
        }

        public IActionResult AddNewInsulinInjection()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewInsulinInjection(AddNewInsulinInjectionViewModel injectionViewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var user = await this.userManager.GetUserAsync(this.User);

            await this.insulinInjectionService.AddAsync(injectionViewModel,user.Id);
            return this.Redirect("/");

        }
    }
}
