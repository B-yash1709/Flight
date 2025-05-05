using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace flightbookingproject2._0.DTO
{
    public class PassengerDTO
    {
        public string FullName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Gender { get; set; } = string.Empty;
        public int BookingId { get; set; }
    }
}