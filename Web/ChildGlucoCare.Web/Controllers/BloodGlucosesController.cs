namespace ChildGlucoCare.Web.Controllers
{
    using ChildGlucoCare.Services.Data;
    using ChildGlucoCare.Web.ViewModels.BloodGlucoses;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class BloodGlucosesController : Controller
    {
        private readonly IBloodGlucoseService bloodGlucoseService;

        public BloodGlucosesController(IBloodGlucoseService bloodGlucoseService)
        {
            this.bloodGlucoseService = bloodGlucoseService;
        }

        // /BloodGlucoses/AddBloodGlucose
        public IActionResult AddBloodGlucose()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBloodGlucose(AddBloodGlucoseViewModel bloodGlucoseViewModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.bloodGlucoseService.AddBloodGlucoseAsync(bloodGlucoseViewModel);

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
