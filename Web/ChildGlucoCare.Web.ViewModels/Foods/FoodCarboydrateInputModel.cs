namespace ChildGlucoCare.Web.ViewModels.Foods
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

  public  class FoodCarboydrateInputModel
    {
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string FoodName { get; set; }

        [Required]
        [Range(0,100)]
        public int AmountInGrams { get; set; }
    }
}
