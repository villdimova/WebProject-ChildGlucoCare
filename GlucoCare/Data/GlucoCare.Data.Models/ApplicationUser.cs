// ReSharper disable VirtualMemberCallInConstructor
namespace GlucoCare.Data.Models
{
    using System;
    using System.Collections.Generic;

    using GlucoCare.Data.Common.Models;

    using Microsoft.AspNetCore.Identity;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.CarbohydrateIntakesRecords = new HashSet<CarbohydrateIntakesRecord>();
            this.InjectedInsulinRecords = new HashSet<InjectedInsulinsRecord>();
            this.BloodGlucosesRecords = new HashSet<BloodGlucosesRecord>();

        }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public decimal InsulinSensibility { get; set; }

        public virtual ICollection<BloodGlucosesRecord> BloodGlucosesRecords { get; set; }

        public virtual ICollection<CarbohydrateIntakesRecord> CarbohydrateIntakesRecords { get; set; }

        public virtual ICollection<InjectedInsulinsRecord> InjectedInsulinRecords { get; set; }


        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
    }
}
