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
   public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public async Task<Payment> MakePaymentAsync(PaymentDTO paymentDto)
        {
            var payment = new Payment
            {
                BookingId = paymentDto.BookingId,
                PaymentMethod = paymentDto.PaymentMode,
                Amount = paymentDto.Amount,
                PaymentDate = DateTime.UtcNow
            };

            return await _paymentRepository.MakePaymentAsync(payment);
        }

        public async Task<Payment> GetPaymentDetailsAsync(int id)
        {
            return await _paymentRepository.GetPaymentByIdAsync(id);
        }
    }
}