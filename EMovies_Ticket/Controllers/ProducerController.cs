using EMovies_Ticket.Data;
using EMovies_Ticket.Data.Services;
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
            //await _producerService.GetAllAsync();
            return View();
        }
    }
}
