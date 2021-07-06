namespace ChildGlucoCare.Web.ViewModels.BloodGlucoses
{
    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Data.Models.Enums;
    using ChildGlucoCare.Services.Mapping;

    public class EditBloodGlucoseInputModel : BloodGlucoseInputModel, IMapFrom<BloodGlucose>
    {
        public int Id { get; set; }

        public BloodGlocoseStatus BloodGlocoseStatus { get; set; }
    }
}
