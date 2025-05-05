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
public class FlightController : ControllerBase
{
    private readonly IFlightService _service;

    public FlightController(IFlightService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllFlights()
    {
        var flights = await _service.GetAllFlightsAsync();
        return Ok(flights);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetFlight(int id)
    {
        var flight = await _service.GetFlightByIdAsync(id);
        if (flight == null) return NotFound();
        return Ok(flight);
    }

    [HttpPost]
    public async Task<IActionResult> AddFlight([FromBody] FlightDTO dto)
    {
        var flight = await _service.AddFlightAsync(dto);
        return CreatedAtAction(nameof(GetFlight), new { id = flight.FlightID }, flight);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateFlight(int id, [FromBody] FlightDTO dto)
    {
        var updated = await _service.UpdateFlightAsync(id, dto);
        if (updated == null) return NotFound();
        return Ok(updated);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteFlight(int id)
    {
        var result = await _service.DeleteFlightAsync(id);
        if (!result) return NotFound();
        return NoContent();
    }
}

}