namespace GlucoCare.Web.ViewModels.Settings
{
    using GlucoCare.Data.Models;
    using GlucoCare.Services.Mapping;

    using AutoMapper;

    public class SettingViewModel : IMapFrom<Setting>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public string NameAndValue { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Setting, SettingViewModel>().ForMember(
                m => m.NameAndValue,
                opt => opt.MapFrom(x => x.Name + " = " + x.Value));
        }
    }
}
