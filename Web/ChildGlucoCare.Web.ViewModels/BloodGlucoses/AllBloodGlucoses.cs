namespace ChildGlucoCare.Web.ViewModels.BloodGlucoses
{
    using System.Collections.Generic;

    public class AllBloodGlucoses
    {
        public AllBloodGlucoses()
        {
            this.BloodGlucoses = new HashSet<BloodGlucoseViewModel>();
        }

        public IEnumerable<BloodGlucoseViewModel> BloodGlucoses { get; set; }
    }
}
