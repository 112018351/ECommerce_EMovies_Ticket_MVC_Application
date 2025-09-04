using EMovies_Ticket.Data.Base;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace EMovies_Ticket.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Full Name")]
        [Required(ErrorMessage ="Full Name is required")]
        [StringLength(50,MinimumLength = 3,ErrorMessage ="full name between 3 and 50 char")]
        public string FullName { get; set; }
        [Display(Name = "BioGraphy")]
        [Required]
        public string Bio { get; set; }
        [Display(Name = "Profile Picture")]
        [Required]
        public string ProfilePictureURL { get; set; }

        // Relationships
        [ValidateNever]
      public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
