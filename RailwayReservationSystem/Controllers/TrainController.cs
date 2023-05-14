using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RailwayReservationSystem.Models;
using RailwayReservationSystem.Repository;

namespace RailwayReservationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainController : ControllerBase
    {
        private readonly ITrain Itrain;

        public TrainController(ITrain trainRepository)
        {
            this.Itrain = trainRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Train>>> GetAll()
        {
            return await Itrain.GetTrains();
        }

        [HttpGet("GetSearch")]
        public async Task<ActionResult<Train>> GetSearch(string source, string destination, DateTime departureTime)
        {
            return await Itrain.CheckAvailability(source, destination, departureTime);
        }
    }
}
