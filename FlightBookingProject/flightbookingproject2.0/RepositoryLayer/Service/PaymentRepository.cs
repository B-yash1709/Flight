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
   public class PaymentRepository : IPaymentRepository
    {
        private readonly FlightBookingDbContext _context;

        public PaymentRepository(FlightBookingDbContext context)
        {
            _context = context;
        }

        public async Task<Payment> MakePaymentAsync(Payment payment)
        {
            _context.Payments.Add(payment);
            await _context.SaveChangesAsync();
            return payment;
        }

        public async Task<Payment> GetPaymentByIdAsync(int id)
        {
            return await _context.Payments.Include(p => p.Booking)
                                        .FirstOrDefaultAsync(p => p.PaymentId == id);
        }
    }
}