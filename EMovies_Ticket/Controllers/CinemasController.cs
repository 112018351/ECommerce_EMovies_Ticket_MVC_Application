using EMovies_Ticket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EMovies_Ticket.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;

        public CinemasController(AppDbContext context)
        {
            this._context = context;
        }
        public async Task<IActionResult> GetAllCinemas()
        {
            var data = await _context.Cinemas.ToListAsync();
            return View(data);
        }
    }
}
