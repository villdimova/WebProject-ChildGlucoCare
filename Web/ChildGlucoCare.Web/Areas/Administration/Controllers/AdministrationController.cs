namespace ChildGlucoCare.Web.Areas.Administration.Controllers
{
    using ChildGlucoCare.Common;
    using ChildGlucoCare.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
