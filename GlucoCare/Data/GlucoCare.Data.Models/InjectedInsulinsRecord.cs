namespace GlucoCare.Data.Models
{
    using System;
    using System.Collections.Generic;

    using GlucoCare.Data.Common.Models;

    public class InjectedInsulinsRecord : BaseDeletableModel<int>
    {
        public InjectedInsulinsRecord()
        {
            this.InjectedInsulins = new HashSet<InjectedInsulin>();
        }

        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<InjectedInsulin> InjectedInsulins { get; set; }

    }
}
