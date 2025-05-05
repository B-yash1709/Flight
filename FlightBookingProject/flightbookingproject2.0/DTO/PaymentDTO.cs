using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace flightbookingproject2._0.DTO
{
    public class PaymentDTO
    {
        public int BookingId { get; set; }
        public string PaymentMode { get; set; }
        public double Amount { get; set; }
    }
}