namespace ChildGlucoCare.Web.ViewModels.Foods
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ChildGlucoCare.Data.Models.Enums;

    public class AllFoodsViewModel
    {
        public string FoodType { get; set; }

        [Display(Name = "Search for  Food")]
        public string SearchTerm { get; set; }

        public IEnumerable<FoodViewModel> Foods { get; set; }
    }
}
