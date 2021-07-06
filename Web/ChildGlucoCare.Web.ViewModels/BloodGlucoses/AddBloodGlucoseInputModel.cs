namespace ChildGlucoCare.Web.ViewModels.BloodGlucoses
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class AddBloodGlucoseInputModel: BloodGlucoseInputModel
    {
        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: yyyy-MM-dd}")]
        public DateTime Date { get; set; }
    }
}
