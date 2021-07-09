namespace ChildGlucoCare.Web.ViewModels.SportActivities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Mvc.Rendering;

    using static ChildGlucoCare.Data.Common.DataConstants;

    public class AddSportActivityViewModel
    {
        public AddSportActivityViewModel()
        {
            this.SportNames = new List<SelectListItem>();
        }

        public string SportName { get; set; }

        [Required]
        [Display(Name = "Duration in minutes")]
        [Range(MinSportDuration, MaxSportDuration, ErrorMessage = "The Duration of the Sport activity should be between 10 and 360 minutes.")]
        public int Duration { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        public string UserName { get; set; }

        public int SportId { get; set; }

        public IEnumerable<SelectListItem> SportNames { get; set; }
    }
}
