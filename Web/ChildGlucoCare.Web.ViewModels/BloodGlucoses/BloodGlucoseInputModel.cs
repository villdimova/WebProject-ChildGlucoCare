namespace ChildGlucoCare.Web.ViewModels.BloodGlucoses
{
    using System.ComponentModel.DataAnnotations;

    public abstract class BloodGlucoseInputModel
    {
        [Required]
        [Range((double)1.0, 30.0)]
        [Display(Name = "Glucose Level")]
        public double CurrentGlucoseLevel { get; set; }
    }
}
