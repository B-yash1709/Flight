using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using flightbookingproject2._0.DTO;
using flightbookingproject2._0.Model;

namespace flightbookingproject2._0.BusinessLayer.Interface
{
    public interface IFlightService
    {
        Task<List<Flight>> GetAllFlightsAsync();
        Task<Flight> GetFlightByIdAsync(int flightId);
        Task<Flight> AddFlightAsync(FlightDTO dto);
        Task<Flight> UpdateFlightAsync(int flightId, FlightDTO dto);
        Task<bool> DeleteFlightAsync(int flightId);
    }
}