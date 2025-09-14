using EMovies_Ticket.Data;
using EMovies_Ticket.Data.Services;
using EMovies_Ticket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EMovies_Ticket.Controllers
{
    public class ProducerController : Controller
    {
        private readonly IProducerService _producerService;

        public ProducerController(IProducerService producer)
        {
           _producerService = producer;
        }
        public async Task<IActionResult> GetAllProducers()
        {
            var data = await _producerService.GetAllAsync();
            return View(data);
        }
        // Get:Producer/Details/1
        public async Task<IActionResult> ProducerDetails(int id)
        {
           var data  =  await _producerService.GetByIdAsync(id);
            if (data == null)
            {
                return View("NotFound");
            }
            return View(data);
        }

        // create/producer
        [HttpGet]
        public IActionResult CreateProducer()
        {

            return View(); 
        }
        [HttpPost]
        public async Task<IActionResult> CreateProducer([Bind("FullName,Bio,ProfilePictureURL")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View("producer");
            }
            await _producerService.AddAsync(producer);
            return RedirectToAction("GetAllProducers");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateProducer(int id)
        {
            var data = await _producerService.GetByIdAsync(id);
            if (data  == null)
            {
                return View("NotFound");
                
            }
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProducer(int id,Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            if (id == producer.Id)
            {
                await _producerService.UpdateAsync(id,producer);
                return RedirectToAction(nameof(GetAllProducers));
            }

            return View(producer);
        }

        [HttpGet]
        public async Task<IActionResult> DeleteProducer(int id)
        {
            var data = await _producerService.GetByIdAsync(id);
            if (data == null)
            {
                return View("NotFound");
                
            }
            return View(data);
        }


        [HttpPost,ActionName("DeleteProducer")]

        public async Task<IActionResult> DeleteProducerConfirmed(int id)
        {
            var data = await _producerService.GetByIdAsync(id);
            if (data == null)
            {
                return View("NotFound");
            }
            await _producerService.DeleteAsync(id);

            return RedirectToAction("GetAllProducers");
        }
    }
}
