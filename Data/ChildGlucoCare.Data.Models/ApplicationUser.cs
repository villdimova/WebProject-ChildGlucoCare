// ReSharper disable VirtualMemberCallInConstructor
namespace ChildGlucoCare.Data.Models
{
    using System;
    using System.Collections.Generic;

    using ChildGlucoCare.Data.Common.Models;

    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.BloodGlucoses = new HashSet<BloodGlucose>();
            this.SportActivities = new HashSet<SportActivity>();
            this.InsulinInjections = new HashSet<InsulinInjection>();
            this.GetCarbohydrateIntakes = new HashSet<CarbohydrateIntake>();
            this.StatisticPeriods = new HashSet<StatisticPeriod>();
        }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public double InsulinSensitivity { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        public virtual ICollection<BloodGlucose> BloodGlucoses { get; set; }

        public virtual ICollection<SportActivity> SportActivities { get; set; }

        public virtual ICollection<InsulinInjection> InsulinInjections { get; set; }

        public virtual ICollection<CarbohydrateIntake> GetCarbohydrateIntakes { get; set; }

        public virtual ICollection<StatisticPeriod> StatisticPeriods { get; set; }
    }
}
