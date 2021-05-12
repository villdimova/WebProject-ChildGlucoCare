﻿namespace GlucoCare.Web.Areas.Administration.Controllers
{
    using GlucoCare.Common;
    using GlucoCare.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
