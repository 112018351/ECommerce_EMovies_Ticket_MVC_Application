using EMovies_Ticket.Data;
using EMovies_Ticket.Data.Services;
using EMovies_Ticket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EMovies_Ticket.Controllers
{
    public class CinemasController : Controller
    {
        private readonly CinemasService _cinemasService;

        public CinemasController(CinemasService cinemasService)
        {
            this._cinemasService = cinemasService;
        }
        public async Task<IActionResult> GetAllCinemas()
        {
            var data = await _cinemasService.GetAllAsync();
            return View(data);
        }

        // Get:Producer/Details/1
        public async Task<IActionResult> CinemasDetails(int id)
        {
            var data = await _cinemasService.GetByIdAsync(id);
            if (data == null)
            {
                return View("NotFound");
            }
            return View(data);
        }

        // create/producer
        [HttpGet]
        public  IActionResult CreateCinemas()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCinema([Bind("FullName,Bio,ProfilePictureURL")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View("cinema");
            }
            await _cinemasService.AddAsync(cinema);
            return RedirectToAction("GetAllCinemas");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateCinema(int id)
        {
            var data = await _cinemasService.GetByIdAsync(id);
            if (data == null)
            {
                return View("NotFound");

            }
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCinema(int id, Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            if (id == cinema.Id)
            {
                await _cinemasService.UpdateAsync(id, cinema);
                return RedirectToAction(nameof(GetAllCinemas));
            }

            return View(cinema);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteCinema(int id)
        {
            var data = await _cinemasService.GetByIdAsync(id);
            if (data == null)
            {
                return View("NotFound");

            }
            return View(data);
        }


        [HttpPost, ActionName("DeleteCinema")]

        public async Task<IActionResult> DeleteCinemaConfirmed(int id)
        {
            var data = await _cinemasService.GetByIdAsync(id);
            if (data == null)
            {
                return View("NotFound");
            }
            await _cinemasService.DeleteAsync(id);

            return RedirectToAction("GetAllCinemas");
        }
    }
}
