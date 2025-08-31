using System.ComponentModel.DataAnnotations;

namespace EMovies_Ticket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Full Name")]
        public string FullName { get; set; }
        [Display(Name = "BioGraphy")]
        public string Bio { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        // Relationships
      public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
