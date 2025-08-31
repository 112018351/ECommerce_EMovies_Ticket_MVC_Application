using EMovies_Ticket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EMovies_Ticket.Controllers
{
    public class ProducerController : Controller
    {
        private readonly AppDbContext _context;

        public ProducerController(AppDbContext context)
        {
            this._context = context;
        }
        public async Task<IActionResult> GetAllProducers()
        {
            var data = await _context.Producers.ToListAsync();
            return View(data);
        }
    }
}
