namespace ChildGlucoCare.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using ChildGlucoCare.Services.Data;
    using ChildGlucoCare.Web.ViewModels.InsulinInjections;
    using Microsoft.AspNetCore.Mvc;

    public class InsulinInjectionsController : Controller
    {
        private readonly IInsulinInjectionsService insulinInjectionService;

        public InsulinInjectionsController(IInsulinInjectionsService insulinInjectionService)
        {
            this.insulinInjectionService = insulinInjectionService;
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

            await this.insulinInjectionService.AddAsync(injectionViewModel);
            return this.Redirect("/");

        }
    }
}
