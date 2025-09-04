using EMovies_Ticket.Data.Base;
using EMovies_Ticket.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace EMovies_Ticket.Data.Services
{
    public class ActorService : EntityBaseRepository<Actor> ,IActorService
    {
        private readonly AppDbContext _context;

        public ActorService(AppDbContext context) : base(context) { }
 


    }
}
