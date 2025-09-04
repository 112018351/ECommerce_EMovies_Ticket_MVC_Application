using EMovies_Ticket.Data.Base;
using EMovies_Ticket.Models;

namespace EMovies_Ticket.Data.Services
{
    public class ProducerService : EntityBaseRepository<Producer>,IProducerService 
    {
      
        public ProducerService(AppDbContext context) : base(context)
        {
        }
    }
}
