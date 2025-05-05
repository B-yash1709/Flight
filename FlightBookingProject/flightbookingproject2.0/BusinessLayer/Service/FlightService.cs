using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using flightbookingproject2._0.BusinessLayer.Interface;
using flightbookingproject2._0.DTO;
using flightbookingproject2._0.Model;
using flightbookingproject2._0.RepositoryLayer.Interface;

namespace flightbookingproject2._0.BusinessLayer.Service
{
   public class FlightService : IFlightService
    {
        private readonly IFlightRepository _repository;

        public FlightService(IFlightRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Flight>> GetAllFlightsAsync()
        {
            return await _repository.GetAllFlightsAsync();
        }

        public async Task<Flight> GetFlightByIdAsync(int flightId)
        {
            return await _repository.GetFlightByIdAsync(flightId);
        }

        public async Task<Flight> AddFlightAsync(FlightDTO dto)
        {
            var flight = new Flight
            {
                Departure_Airport = dto.Departure_Airport,
                Arrival_Airport = dto.Arrival_Airport,
                Departure_Time = dto.Departure_Time,
                Arrival_Time = dto.Arrival_Time,
                Flight_Duration = dto.Flight_Duration,
                BaseFare = dto.BaseFare,
                Seats_Available = dto.Seats_Available
            };
            return await _repository.AddFlightAsync(flight);
        }

        public async Task<Flight> UpdateFlightAsync(int flightId, FlightDTO dto)
        {
            var flight = await _repository.GetFlightByIdAsync(flightId);
            if (flight == null) return null;

            flight.Departure_Airport = dto.Departure_Airport;
            flight.Arrival_Airport = dto.Arrival_Airport;
            flight.Departure_Time = dto.Departure_Time;
            flight.Arrival_Time = dto.Arrival_Time;
            flight.Flight_Duration = dto.Flight_Duration;
            flight.BaseFare = dto.BaseFare;
            flight.Seats_Available = dto.Seats_Available;

            return await _repository.UpdateFlightAsync(flight);
        }

        public async Task<bool> DeleteFlightAsync(int flightId)
        {
            return await _repository.DeleteFlightAsync(flightId);
        }
    }
}