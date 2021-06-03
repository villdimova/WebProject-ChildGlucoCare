using System;
using System.Collections.Generic;
using System.Text;

namespace ChildGlucoCare.Web.ViewModels.CarbohydtrateIntakes
{
    public class AllEatenBeuViewModel
    {
        public AllEatenBeuViewModel()
        {
            this.AllBeu = new HashSet<BeuViewModel>();
        }

        public IEnumerable<BeuViewModel> AllBeu { get; set; }
    }
}
