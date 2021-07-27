namespace ChildGlucoCare.Web.Controllers
{
    using System;
    using System.Threading.Tasks;

    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Web.ViewModels.Insulins;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class InsulinsController : BaseController
    {
        private readonly IInsulinsService insulinsService;

        public InsulinsController(IInsulinsService insulinsService)
        {
            this.insulinsService = insulinsService;
        }

        public async Task<IActionResult> InsulinProfile()
        {
            if (!this.User.IsInRole("Administrator"))
            {
                return this.RedirectToAction(nameof(this.UserAllProfiles));
            }

            var viewModel = new AllInsulinsProfileViewModel
            {
                Insulins = await this.insulinsService.GetAll<InsulinProfileViewModel>(),
            };
            return this.View(viewModel);
        }

        public async Task<IActionResult> UserAllProfiles()
        {
            var viewModel = new AllInsulinsProfileViewModel
            {
                Insulins = await this.insulinsService.GetAll<InsulinProfileViewModel>(),
            };
            return this.View(viewModel);
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Create(CreateInsulinInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.insulinsService.CreateAsync(input);
            return this.Redirect("/Insulins/InsulinProfile");
        }

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(int id)
        {
            var viewModel = await this.insulinsService.GetInsulinAsync<EditInsulinInputModel>(id);
            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Edit(EditInsulinInputModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(inputModel);
            }

            await this.insulinsService.EditInsulinAsync(inputModel);
            return this.Redirect($"/Insulins/InsulinProfile");
        }

        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Delete(int id)
        {
            await this.insulinsService.DeleteInsulinAsync(id);
            return this.Redirect("/Insulins/InsulinProfile");
        }
    }
}
