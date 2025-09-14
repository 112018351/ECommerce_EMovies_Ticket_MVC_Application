//using EMovies_Ticket.Data;
//using EMovies_Ticket.Data.Services;
//using EMovies_Ticket.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace EMovies_Ticket.Controllers
//{
//    public class MoviesController : Controller
//    {

//        private readonly MovieService _movieService;

//        public MoviesController(MovieService movieService)
//        { 
       
//            this._movieService = movieService;
//        }
//        public async Task<IActionResult> GetAllMovies()
//        {
//            var data = await _movieService.GetAllAsync();
//            return View(data);
//        }

//        //// Get:Producer/Details/1
//        //public async Task<IActionResult> MoviesDetails(int id)
//        //{
//        //    var data = await _movieService.GetByIdAsync(id);
//        //    if (data == null)
//        //    {
//        //        return View("NotFound");
//        //    }
//        //    return View(data);
//        //}

//        //// create/producer
//        //[HttpGet]
//        //public  IActionResult CreateMovies()
//        //{

//        //    return View();
//        //}
//        //[HttpPost]
//        //public async Task<IActionResult> CreateMovies([Bind("FullName,Bio,ProfilePictureURL")] Movie movies) 
//        //{
//        //    if (!ModelState.IsValid)
//        //    {
//        //        return View("movies");
//        //    }
//        //    await _movieService.AddAsync(movies);
//        //    return RedirectToAction("GetAllMovies");
//        //}
//        //[HttpGet]
//        //public async Task<IActionResult> UpdateMovies(int id)
//        //{
//        //    var data = await _movieService.GetByIdAsync(id);
//        //    if (data == null)
//        //    {
//        //        return View("NotFound");

//        //    }
//        //    return View(data);
//        //}
//        //[HttpPost]
//        //public async Task<IActionResult> UpdateMovies(int id, Movie movies)
//        //{
//        //    if (!ModelState.IsValid)
//        //    {
//        //        return View(movies);
//        //    }
//        //    if (id == movies.Id)
//        //    {
//        //        await _movieService.UpdateAsync(id, movies);
//        //        return RedirectToAction(nameof(GetAllMovies));
//        //    }

//        //    return View(movies);
//        //}

//        //[HttpGet]
//        //public async Task<IActionResult> DeleteMovie(int id)
//        //{
//        //    var data = await _movieService.GetByIdAsync(id);
//        //    if (data == null)
//        //    {
//        //        return View("NotFound");

//        //    }
//        //    return View(data);
//        //}


//        //[HttpPost, ActionName("DeleteMovie")]

//        //public async Task<IActionResult> DeleteMovieConfirmed(int id)
//        //{
//        //    var data = await _movieService.GetByIdAsync(id);
//        //    if (data == null)
//        //    {
//        //        return View("NotFound");
//        //    }
//        //    await _movieService.DeleteAsync(id);

//        //    return RedirectToAction("GetAllMovies");
//        //}
//    }
//}
