namespace ChildGlucoCare.Web.Controllers
{
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
            var viewModel = new AllInsulinsProfileViewModel
            {
                Insulins = await this.insulinsService.GetAll<InsulinProfileViewModel>(),
            };
            return this.View(viewModel);
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateInsulinInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            await this.insulinsService.CreateAsync(input);
            return this.Redirect("/Insulins/InsulinProfile");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var viewModel = await this.insulinsService.GetInsulinAsync<EditInsulinInputModel>(id);
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditInsulinInputModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(inputModel);
            }

            await this.insulinsService.EditInsulinAsync(inputModel);
            return this.Redirect($"/Insulins/InsulinProfile");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await this.insulinsService.DeleteInsulinAsync(id);
            return this.Redirect("/Insulins/InsulinProfile");
        }
    }
}
