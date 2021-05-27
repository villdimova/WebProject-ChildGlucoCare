namespace ChildGlucoCare.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using ChildGlucoCare.Data.Common.Models;

    public class UserDashboard: BaseDeletableModel<int>
    {
        public UserDashboard()
        {
           // this.SportActivities = new HashSet<SportActivity>();
         //   this.BloodGlucoses = new HashSet<BloodGlucose>();
           // this.InsulinInjections = new HashSet<InsulinInjection>();
         //   this.CarbohydrateIntakes = new HashSet<CarbohydrateIntake>();
        }

   //     [ForeignKey(nameof(ApplicationUser))]
    //    public string ApplicationUserId { get; set; }

     //   public ApplicationUser ApplicationUser { get; set; }

      //  public virtual ICollection<CarbohydrateIntake> CarbohydrateIntakes { get; set; }

    //    public virtual ICollection<BloodGlucose> BloodGlucoses { get; set; }

     //   public virtual ICollection<InsulinInjection> InsulinInjections { get; set; }

     //   public virtual  ICollection<SportActivity> SportActivities { get; set; }
       
    }
}
