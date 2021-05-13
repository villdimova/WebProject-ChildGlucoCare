namespace GlucoCare.Data.Models
{
    using System.Collections.Generic;

    using GlucoCare.Data.Common.Models;

    public class BloodGlucosesRecord: BaseDeletableModel<int>
    {
        public BloodGlucosesRecord()
        {
            this.BloodGlucoses = new HashSet<BloodGlucose>();
        }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<BloodGlucose> BloodGlucoses { get; set; }
    }
}
