namespace ChildGlucoCare.Data.Models
{ 
    using System.Collections.Generic;

    using ChildGlucoCare.Data.Common.Models;

    public class DiabeticDiary : BaseDeletableModel<int>
    {
        public DiabeticDiary()
        {
            this.BloodGlocoseRecords = new HashSet<BloodGlucose>();
            this.CarbohydrateIntakeRecords = new HashSet<CarbohydrateIntake>();
            this.SportActivitiyRecords = new HashSet<SportActivity>();
            this.InjectedInsulinRecords = new HashSet<InjectedInsulin>();
        }

        public ICollection<BloodGlucose> BloodGlocoseRecords { get; set; }

        public ICollection<CarbohydrateIntake> CarbohydrateIntakeRecords { get; set; }

        public ICollection<InjectedInsulin> InjectedInsulinRecords { get; set; }

        public ICollection<SportActivity> SportActivitiyRecords { get; set; }

    }
}