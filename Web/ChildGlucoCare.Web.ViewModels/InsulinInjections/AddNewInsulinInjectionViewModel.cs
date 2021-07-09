namespace ChildGlucoCare.Web.ViewModels.InsulinInjections
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Mvc.Rendering;

    using static ChildGlucoCare.Data.Common.DataConstants;

    public class AddNewInsulinInjectionViewModel
    {
        public AddNewInsulinInjectionViewModel()
        {
            this.InsulinNames = new List<SelectListItem>();
        }

        [Required]
        [Range(MinInsulinInjection, MaxInsulinInjection)]
        [Display(Name = "Insulin Dose")]
        public double InsulinDose { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: yyyy-MM-dd}")]
        public DateTime Date { get; set; }

        [Required]
        [Range(MinBloodGlucoseLevel, MaxBloodGlucoseLevel)]
        [Display(Name = "Current Glucose Level")]
        public double CurrentGlucoseLevel { get; set; }

        [Required]
        [Range(MinTotalBeu, MaxTotalBeu)]
        public double TotalBeu { get; set; }

        [Display(Name = "Insulin name")]
        public string InsulinName { get; set; }

        public int SportId { get; set; }

        [Display(Name = "Insulin name")]
        public IEnumerable<SelectListItem> InsulinNames { get; set; }
    }
}
