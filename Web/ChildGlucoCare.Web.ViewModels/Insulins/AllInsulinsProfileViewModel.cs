using System.Collections.Generic;

namespace ChildGlucoCare.Web.ViewModels.Insulins
{
   public class AllInsulinsProfileViewModel
    {
        public AllInsulinsProfileViewModel()
        {
            this.Insulins = new HashSet<InsulinProfileViewModel>();
        }
        public IEnumerable<InsulinProfileViewModel> Insulins { get; set; }
    }
}
