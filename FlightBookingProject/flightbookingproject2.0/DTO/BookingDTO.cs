using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace flightbookingproject2._0.DTO
{
    public class BookingDTO
    {
        public int UserId { get; set; }
        public int FlightId { get; set; }
        public int NoOfSeats { get; set; }
        public decimal TotalAmount { get; set; }
    }
}