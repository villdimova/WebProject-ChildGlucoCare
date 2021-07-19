namespace ChildGlucoCare.Web.ViewModels.InsulinInjections
{
    using System.Collections.Generic;

    public class AllInsulinInjections
    {
        public AllInsulinInjections()
        {
            this.InsulinInjections = new HashSet<InsulinInjectionViewModel>();
        }

        public IEnumerable<InsulinInjectionViewModel> InsulinInjections { get; set; }
    }
}
