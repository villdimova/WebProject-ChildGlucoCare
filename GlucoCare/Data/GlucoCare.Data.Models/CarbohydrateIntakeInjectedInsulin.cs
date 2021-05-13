namespace GlucoCare.Data.Models
{
    public  class CarbohydrateIntakeInjectedInsulin
    {
        public int InjectedInsulinId { get; set; }

        public virtual InjectedInsulin InjectedInsulin { get; set; }

        public virtual CarbohydrateIntake CarbohidrateIntake { get; set; }

        public int CarbohidrateIntakeId { get; set; }
    }
}
