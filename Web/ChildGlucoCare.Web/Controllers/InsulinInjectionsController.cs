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

        public IActionResult AddNewInsulinInjection()
        {
            var viewModel = new AddNewInsulinInjectionViewModel
            {
                InsulinNames = this.insulinsService.GetAllNames(),
            };

            return this.View(viewModel);
        }

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
            return this.RedirectToAction(nameof(this.AllInsulinInjections));
        }

        public async Task<IActionResult> AllInsulinInjections()
        {
            var viewModel = new AllInsulinInjections
            {
                InsulinInjections = await this.insulinInjectionService.GetAll<InsulinInjectionViewModel>(),
            };
            return this.View(viewModel);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var viewModel = await this.insulinInjectionService.GetInsulinInjectionAsync<EditInsulinInjectionInputModel>(id);
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditInsulinInjectionInputModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(inputModel);
            }

            await this.insulinInjectionService.EditInsulinInjectionAsync(inputModel);
            return this.RedirectToAction(nameof(this.AllInsulinInjections));
        }

        public async Task<IActionResult> Delete(int id)
        {
            await this.insulinInjectionService.DeleteInsulinInjectionAsync(id);
            return this.RedirectToAction(nameof(this.AllInsulinInjections));
        }
    }
}
