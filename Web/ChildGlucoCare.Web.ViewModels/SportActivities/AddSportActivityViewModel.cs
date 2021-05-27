namespace ChildGlucoCare.Web.ViewModels.SportActivities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class AddSportActivityViewModel
    {
        [Required]
        [MinLength(4)]
        public string SportName { get; set; }

        [Required]
        [Display(Name ="Duration in minutes")]
        [Range(0,360)]
        public int Duration { get; set; }

        [Required]
        public DateTime Date { get; set; }

        //[Required]
        //[MinLength(2)]
        //[MaxLength(15)]
        //[RegularExpression("^[A-Z]{1}[a-z0-9]+$")]
        public string UserName { get; set; }

    }
}
