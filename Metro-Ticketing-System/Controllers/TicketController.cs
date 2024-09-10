using Metro_Ticketing_System.Dtos;
using Metro_Ticketing_System.Interfaces;
using Metro_Ticketing_System.Repository;
using Metro_Ticketing_System.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Metro_Ticketing_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly IStationRepository _stationRepository;
        private readonly ITicketService _ticketService;

        public TicketController(ITicketService ticketService, IStationRepository stationRepository)
        {
            _stationRepository = stationRepository;
            _ticketService = ticketService;
        }

        [HttpPost("price")]

        public async Task<IActionResult> GetPrice([FromBody] TripDetailsDto tripDetails)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var station1 = await _stationRepository.GetStation(tripDetails.StartStation);

            var station2 = await _stationRepository.GetStation(tripDetails.EndStation);
            if (station1 == null || station2 == null) return BadRequest(new { Message = "Invalid Station Name" });

            var distance = await  _ticketService.GetDistance(station1, station2);
            var price = _ticketService.GetPrice(distance);
            return Ok(new { NumberOfStations = distance, Price = price });
        }
    }
}
