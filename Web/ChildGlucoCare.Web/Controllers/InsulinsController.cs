namespace ChildGlucoCare.Web.Controllers
{
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

        public IActionResult InsulinProfile()
        {
            var viewModel = new AllInsulinsProfileViewModel
            {
                Insulins = this.insulinsService.GetAll<InsulinProfileViewModel>(),
            };
            return this.View(viewModel);
        }
    }
}
