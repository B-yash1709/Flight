using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using flightbookingproject2._0.DTO;
using flightbookingproject2._0.Model;

namespace flightbookingproject2._0.BusinessLayer.Interface
{
    public interface IBookingService
    {
        Task<Booking> CreateBookingAsync(BookingDTO bookingDto);
        Task<IEnumerable<Booking>> GetBookingsAsync();
        Task<Booking?> GetBookingByIdAsync(int id);
        Task<bool> CancelBookingAsync(int id);
    }
}