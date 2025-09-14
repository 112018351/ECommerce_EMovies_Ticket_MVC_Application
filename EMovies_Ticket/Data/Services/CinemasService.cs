using EMovies_Ticket.Data.Base;
using EMovies_Ticket.Models;

namespace EMovies_Ticket.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema> , ICinemasService
    {
        private readonly AppDbContext _context;

        public CinemasService(AppDbContext context) : base(context) { }
     
    }
}
