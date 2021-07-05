namespace ChildGlucoCare.Web.ViewModels.Insulins
{
    using System.ComponentModel.DataAnnotations;

    using ChildGlucoCare.Data.Models;
    using ChildGlucoCare.Services.Mapping;

    public class EditInsulinInputModel: IMapFrom<Insulin>
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public string Taken { get; set; }

        [Required]
        public string Onset { get; set; }

        [Required]
        public string Peak { get; set; }

        [Required]
        public string Duration { get; set; }
    }
}
