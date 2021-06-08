namespace ChildGlucoCare.Web.Controllers
{
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Data.Contracts;
    using ChildGlucoCare.Web.ViewModels.BloodGlucoses;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class BloodGlucosesController : Controller
    {
        private readonly IBloodGlucoseService bloodGlucoseService;
        private readonly UserManager<ApplicationUser> userManager;

        public BloodGlucosesController(IBloodGlucoseService bloodGlucoseService
                                                            ,UserManager<ApplicationUser> userManager)
        {
            this.bloodGlucoseService = bloodGlucoseService;
            this.userManager = userManager;
        }

        // /BloodGlucoses/AddBloodGlucose
        public IActionResult AddBloodGlucose()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddBloodGlucose(AddBloodGlucoseViewModel bloodGlucoseViewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var user = await this.userManager.GetUserAsync(this.User);
        

            await this.bloodGlucoseService.AddBloodGlucoseAsync(bloodGlucoseViewModel,user.Id);

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

        public IActionResult AddedLowBloodGlucose()
        {
            return this.View();
        }

        public IActionResult AddedNormalBloodGlucose()
        {
            return this.View();
        }

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
    }
}
