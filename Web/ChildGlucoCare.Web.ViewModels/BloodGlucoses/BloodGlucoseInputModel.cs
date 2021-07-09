namespace ChildGlucoCare.Web.ViewModels.BloodGlucoses
{
    using System.ComponentModel.DataAnnotations;

    using static ChildGlucoCare.Data.Common.DataConstants;

    public abstract class BloodGlucoseInputModel
    {
        [Required]
        [Range((double)MinBloodGlucoseLevel, MaxBloodGlucoseLevel)]
        [Display(Name = "Glucose Level")]
        public double CurrentGlucoseLevel { get; set; }
    }
}
