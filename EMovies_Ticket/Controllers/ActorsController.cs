using EMovies_Ticket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EMovies_Ticket.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context) 
        {
            this._context = context;
        }
        public async Task<IActionResult> GetAllActors()
        {
            var data = await _context.Actors.ToListAsync();
            return View(data);
        }
    }
}
