namespace ChildGlucoCare.Web.Controllers
{
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Web.ViewModels.InsulinInjections;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class InsulinInjectionsController : BaseController
    {
        private readonly IInsulinInjectionsService insulinInjectionService;
        private readonly IInsulinsService insulinsService;
        private readonly UserManager<ApplicationUser> userManager;

        public InsulinInjectionsController(
                                                              IInsulinInjectionsService insulinInjectionService,
                                                              IInsulinsService insulinsService,
                                                              UserManager<ApplicationUser> userManager)
        {
            this.insulinInjectionService = insulinInjectionService;
            this.insulinsService = insulinsService;
            this.userManager = userManager;
        }

        [Authorize]
        public IActionResult AddNewInsulinInjection()
        {
            var viewModel = new AddNewInsulinInjectionViewModel
            {
                InsulinNames = this.insulinsService.GetAllNames(),
            };

            return this.View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddNewInsulinInjection(AddNewInsulinInjectionViewModel injectionViewModel)
        {
            if (!this.ModelState.IsValid)
            {
                injectionViewModel.InsulinNames = this.insulinsService.GetAllNames();
                return this.View(injectionViewModel);
            }

            var user = await this.userManager.GetUserAsync(this.User);

            await this.insulinInjectionService.AddAsync(injectionViewModel, user.Id);
            return this.Redirect("/");
        }
    }
}
