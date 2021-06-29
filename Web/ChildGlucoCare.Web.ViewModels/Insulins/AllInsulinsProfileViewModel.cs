namespace ChildGlucoCare.Web.ViewModels.Insulins
{
    using System.Collections.Generic;

    public class AllInsulinsProfileViewModel
    {
        public AllInsulinsProfileViewModel()
        {
            this.Insulins = new HashSet<InsulinProfileViewModel>();
        }

        public IEnumerable<InsulinProfileViewModel> Insulins { get; set; }
    }
}
