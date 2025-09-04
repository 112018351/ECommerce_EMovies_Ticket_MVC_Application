using EMovies_Ticket.Data;
using EMovies_Ticket.Data.Services;
using EMovies_Ticket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace EMovies_Ticket.Controllers
{
    public class ActorsController : Controller
    {
      private readonly IActorService _actorService;
        public ActorsController(IActorService actorService)
        {
            _actorService = actorService;
        }
        public async Task<IActionResult> GetAllActors()
        {
            var data = await _actorService.GetAllActorsAsync();
            return View(data);
        }

        // Get: Actors/Create
        public IActionResult CreateActor()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateActor([Bind("FullName,Bio,ProfilePictureURL")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
              
                return View(actor);
            }
           await _actorService.AddActorAsync(actor);

            return RedirectToAction("GetAllActors");
        }
        // Get:Actor/Details/1
        public async Task<IActionResult> ActorDetails(int id)
        {
            var actorDetails = await _actorService.GetByIdAsync(id);
            if (actorDetails == null)
            {
                return View("NotFound");
            }
            return View(actorDetails);
        }
        // Get: Actor/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails =  await _actorService.GetByIdAsync(id);
            if (actorDetails == null)
            {
                return View("NotFound");
            }
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,Bio,ProfilePictureURL")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _actorService.UpdateActorAsync(id,actor);
            return RedirectToAction("GetAllActors");
        }
        // Get: Delete/Actor/1
        public async Task<IActionResult> Delete(int id)
        {
            var deleteActor = await _actorService.GetByIdAsync(id);
            if (deleteActor == null)
            {
                return View("NotFound");
            }
            return View(deleteActor);

        }

        [HttpPost, ActionName("Delete")]
       
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deleteActor = _actorService.GetByIdAsync(id);
            if (deleteActor == null)
            {
                return View("NotFound");
            }
            await _actorService.DeleteActorAsync(id);

            return RedirectToAction("GetAllActors");
        }
    }
}
