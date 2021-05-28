using AutoMapper;
using ChildGlucoCare.Data.Models;
using ChildGlucoCare.Data.Models.Enums;
using ChildGlucoCare.Services.Mapping;

namespace ChildGlucoCare.Web.ViewModels.Insulins
{
    public class InsulinProfileViewModel : IMapFrom<Insulin>
    {
        public InsulinType InsulinType { get; set; }

        public string Name { get; set; }

        public string Taken { get; set; }

        public string Onset { get; set; }

        public string Peak { get; set; }

        public string Duration { get; set; }

        
    }
}
