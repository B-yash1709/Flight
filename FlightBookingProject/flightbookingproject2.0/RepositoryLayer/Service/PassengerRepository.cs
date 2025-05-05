using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using flightbookingproject2._0.Context;
using flightbookingproject2._0.Model;
using flightbookingproject2._0.RepositoryLayer.Interface;
using Microsoft.EntityFrameworkCore;

namespace flightbookingproject2._0.RepositoryLayer.Service
{
    public class PassengerRepository : IPassengerRepository
    {
        private readonly FlightBookingDbContext _context;

        public PassengerRepository(FlightBookingDbContext context)
        {
            _context = context;
        }

        public async Task<Passenger> AddPassengerAsync(Passenger passenger)
        {
            _context.Passengers.Add(passenger);
            await _context.SaveChangesAsync();
            return passenger;
        }

        public async Task<IEnumerable<Passenger>> GetAllPassengersAsync()
        {
            return await _context.Passengers.ToListAsync();
        }

        public async Task<Passenger?> GetPassengerByIdAsync(int id)
        {
            return await _context.Passengers.FindAsync(id);
        }

        public async Task<bool> DeletePassengerAsync(int id)
        {
            var passenger = await _context.Passengers.FindAsync(id);
            if (passenger == null) return false;

            _context.Passengers.Remove(passenger);
            await _context.SaveChangesAsync();
            return true;
        }
    }
    }