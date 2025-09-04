using EMovies_Ticket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EMovies_Ticket.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            this._context = context;
        }
        public async Task<IActionResult> GetAllMovies()
        {
            var data = await _context.Movies.Include(a => a.Cinema).OrderBy(o => o.Name).ToListAsync();
            return View(data);
        }
    }
}
