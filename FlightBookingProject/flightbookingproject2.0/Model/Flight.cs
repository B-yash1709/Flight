using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace flightbookingproject2._0.Model
{

    public class Flight
    {
        public int FlightID { get; set; }
        public string Departure_Airport { get; set; }
        public string Arrival_Airport { get; set; }
        public DateTime Departure_Time { get; set; }
        public DateTime Arrival_Time { get; set; }
        public decimal Flight_Duration { get; set; }
        public decimal BaseFare { get; set; }
        public int Seats_Available { get; set; }
        public ICollection<Booking> Bookings { get; set; }

    }

}