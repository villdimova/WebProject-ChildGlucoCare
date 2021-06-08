namespace ChildGlucoCare.Web.ViewModels.SportActivities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Mvc.Rendering;

    public class AddSportActivityViewModel
    {
        public AddSportActivityViewModel()
        {
            this.SportNames = new List<SelectListItem>();
        }

        
        public string SportName { get; set; }

        [Required]
        [Display(Name ="Duration in minutes")]
        [Range(0,360)]
        public int Duration { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        //[Required]
        //[MinLength(2)]
        //[MaxLength(15)]
        //[RegularExpression("^[A-Z]{1}[a-z0-9]+$")]
        public string UserName { get; set; }

        public int SportId { get; set; }

        public IEnumerable<SelectListItem> SportNames { get; set; }

    }
}
