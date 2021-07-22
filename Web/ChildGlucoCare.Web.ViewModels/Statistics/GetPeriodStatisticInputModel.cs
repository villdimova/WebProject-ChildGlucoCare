namespace ChildGlucoCare.Web.ViewModels.Statistics
{
    using System.ComponentModel.DataAnnotations;

    public class GetPeriodStatisticInputModel
    {
        [Required]
        [Range(1, 90)]
        public int Days { get; set; }
    }
}
