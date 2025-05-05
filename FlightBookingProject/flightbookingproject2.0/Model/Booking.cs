using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace flightbookingproject2._0.Model
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public int FlightId { get; set; }
        public DateTime BookingDate { get; set; } = DateTime.Now;
        public int NoOfSeats { get; set; }
        public decimal TotalAmount { get; set; }
        
        [ForeignKey("UserId")]
        public User User { get; set; }
        [ForeignKey("FlightId")]
        public Flight Flight { get; set; }
        public ICollection<Passenger> Passengers { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}