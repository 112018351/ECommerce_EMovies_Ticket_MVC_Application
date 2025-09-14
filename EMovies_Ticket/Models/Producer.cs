using EMovies_Ticket.Data.Base;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace EMovies_Ticket.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "BioGraphy")]
        public string Bio { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [ValidateNever]
        // Relationships
        public List<Movie> Movies { get; set; }
    }
}
