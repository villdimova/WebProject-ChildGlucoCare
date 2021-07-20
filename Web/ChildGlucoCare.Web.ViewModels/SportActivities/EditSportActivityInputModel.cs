namespace ChildGlucoCare.Web.ViewModels.SportActivities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Mapping;
    using Microsoft.AspNetCore.Mvc.Rendering;

    using static ChildGlucoCare.Data.Common.DataConstants;

    public class EditSportActivityInputModel: IMapFrom<SportActivity>
    {
        public int Id { get; set; }

        [Display(Name = "Sport name")]
        public string SportName { get; set; }

        [Display(Name = "Duration in minutes")]
        [Range(MinSportDuration, MaxSportDuration, ErrorMessage = "The Duration of the Sport activity should be between 10 and 360 minutes.")]
        public int Duration { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: yyyy-MM-dd}")]
        public DateTime Date { get; set; }
    }
}
