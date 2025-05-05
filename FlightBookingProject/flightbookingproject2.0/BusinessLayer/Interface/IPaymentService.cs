using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using flightbookingproject2._0.DTO;
using flightbookingproject2._0.Model;

namespace flightbookingproject2._0.BusinessLayer.Interface
{
    public interface IPaymentService
{
    Task<Payment> MakePaymentAsync(PaymentDTO paymentDto);
    Task<Payment> GetPaymentDetailsAsync(int id);
}
}