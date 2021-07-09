namespace ChildGlucoCare.Services.Data.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Web.ViewModels.Insulins;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public interface IInsulinsService
    {
        Task<Insulin> CreateAsync(CreateInsulinInputModel input);

        public Task<T> GetInsulinAsync<T>(int insulinId);

        public Task<Insulin> DeleteInsulinAsync(int insulinId);

        public Task<Insulin> EditInsulinAsync(EditInsulinInputModel inputModel);

        public Task<IEnumerable<T>> GetAll<T>();

        IEnumerable<SelectListItem> GetAllNames();
    }
}
