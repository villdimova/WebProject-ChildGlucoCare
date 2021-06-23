namespace ChildGlucoCare.Services.Data.Contracts
{
    using System.Collections.Generic;

    using Microsoft.AspNetCore.Mvc.Rendering;

    public interface ISportsService
    {
        IEnumerable<SelectListItem> GetAllNames();
    }
}
