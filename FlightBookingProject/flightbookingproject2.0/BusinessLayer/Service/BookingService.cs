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
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task<Booking> CreateBookingAsync(BookingDTO dto)
        {
            var booking = new Booking
            {
                UserId = dto.UserId,
                FlightId = dto.FlightId,
                BookingDate = DateTime.UtcNow,
                NoOfSeats = dto.NoOfSeats,
                TotalAmount = dto.TotalAmount
            };

            return await _bookingRepository.AddBookingAsync(booking);
        }

        public async Task<IEnumerable<Booking>> GetBookingsAsync()
        {
            return await _bookingRepository.GetAllBookingsAsync();
        }

        public async Task<Booking?> GetBookingByIdAsync(int id)
        {
            return await _bookingRepository.GetBookingByIdAsync(id);
        }

        public async Task<bool> CancelBookingAsync(int id)
        {
            return await _bookingRepository.DeleteBookingAsync(id);
        }
    }
}