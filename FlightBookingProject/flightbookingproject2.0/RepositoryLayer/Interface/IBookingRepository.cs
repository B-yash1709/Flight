using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using flightbookingproject2._0.Model;

namespace flightbookingproject2._0.RepositoryLayer.Interface
{
     public interface IBookingRepository
    {
        Task<Booking> AddBookingAsync(Booking booking);
        Task<IEnumerable<Booking>> GetAllBookingsAsync();
        Task<Booking?> GetBookingByIdAsync(int id);
        Task<bool> DeleteBookingAsync(int id);
    }
}