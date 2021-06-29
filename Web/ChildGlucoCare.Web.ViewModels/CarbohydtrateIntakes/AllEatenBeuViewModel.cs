namespace ChildGlucoCare.Web.ViewModels.CarbohydtrateIntakes
{
    using System.Collections.Generic;

    public class AllEatenBeuViewModel
    {
        public AllEatenBeuViewModel()
        {
            this.AllBeu = new HashSet<BeuViewModel>();
        }

        public IEnumerable<BeuViewModel> AllBeu { get; set; }
    }
}
