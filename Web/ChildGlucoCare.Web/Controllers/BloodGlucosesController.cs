namespace ChildGlucoCare.Web.Controllers
{
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Web.ViewModels.BloodGlucoses;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class BloodGlucosesController : BaseController
    {
        private readonly IBloodGlucoseService bloodGlucoseService;
        private readonly UserManager<ApplicationUser> userManager;

        public BloodGlucosesController(
                                                            IBloodGlucoseService bloodGlucoseService,
                                                            UserManager<ApplicationUser> userManager)
        {
            this.bloodGlucoseService = bloodGlucoseService;
            this.userManager = userManager;
        }

        // /BloodGlucoses/AddBloodGlucose
        [Authorize]
        public IActionResult AddBloodGlucose()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBloodGlucose(AddBloodGlucoseInputModel bloodGlucoseViewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(bloodGlucoseViewModel);
            }

            var user = await this.userManager.GetUserAsync(this.User);

            await this.bloodGlucoseService.AddBloodGlucoseAsync(bloodGlucoseViewModel, user);

            if (bloodGlucoseViewModel.CurrentGlucoseLevel <= 4)
            {
                return this.RedirectToAction(nameof(this.AddedLowBloodGlucose));
            }
            else if (bloodGlucoseViewModel.CurrentGlucoseLevel > 4 && bloodGlucoseViewModel.CurrentGlucoseLevel <= 7.5)
            {
                return this.RedirectToAction(nameof(this.AddedNormalBloodGlucose));
            }
            else
            {
                return this.RedirectToAction(nameof(this.AddedHighBloodGlucose));
            }
        }

        [Authorize]
        public IActionResult AddedLowBloodGlucose()
        {
            return this.View();
        }

        [Authorize]
        public IActionResult AddedNormalBloodGlucose()
        {
            return this.View();
        }

        [Authorize]
        public IActionResult AddedHighBloodGlucose()
        {
            var lastBloodGlucose = this.bloodGlucoseService.LastAddedBloodGlucose();

            var viewModel = new SuggestedInsulinCorrectionViewModel
            {
                Date = lastBloodGlucose.Date,
                CurrentGlucoseLevel = lastBloodGlucose.CurrentGlucoseLevel,
                SuggestedCorrectionDoseInsulin = lastBloodGlucose.SuggestedCorrectionDoseInsulin,
            };
            return this.View(viewModel);
        }

        public async Task<IActionResult> AllBloodGlucoses()
        {
            var viewModel = new AllBloodGlucoses
            {
                BloodGlucoses = await this.bloodGlucoseService.GetAll<BloodGlucoseViewModel>(),
            };
            return this.View(viewModel);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var viewModel = await this.bloodGlucoseService.GetBloodGlucoseAsync<EditBloodGlucoseInputModel>(id);
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditBloodGlucoseInputModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(inputModel);
            }

            var user = await this.userManager.GetUserAsync(this.User);
            await this.bloodGlucoseService.EditBloodGlucoseAsync(inputModel, user);
            return this.Redirect($"/BloodGlucoses/AllBloodGlucoses");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await this.bloodGlucoseService.DeleteBloodGlucoseAsync(id);
            return this.Redirect("/BloodGlucoses/AllBloodGlucoses");
        }
    }
}
