using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using flightbookingproject2._0.BusinessLayer.Interface;
using flightbookingproject2._0.DTO;
using Microsoft.AspNetCore.Mvc;

namespace flightbookingproject2._0.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class PassengerController : ControllerBase
    {
        private readonly IPassengerService _passengerService;

        public PassengerController(IPassengerService passengerService)
        {
            _passengerService = passengerService;
        }

        [HttpPost]
        public async Task<IActionResult> AddPassenger([FromBody] PassengerDTO dto)
        {
            var passenger = await _passengerService.CreatePassengerAsync(dto);
            return Ok(passenger);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var passengers = await _passengerService.GetAllPassengersAsync();
            return Ok(passengers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var passenger = await _passengerService.GetPassengerByIdAsync(id);
            return passenger == null ? NotFound() : Ok(passenger);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _passengerService.DeletePassengerAsync(id);
            return result ? Ok("Passenger deleted.") : NotFound();
        }
    }
}