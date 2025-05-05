using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using flightbookingproject2._0.Model;

namespace flightbookingproject2._0.RepositoryLayer.Interface
{
   public interface IPaymentRepository
{
    Task<Payment> MakePaymentAsync(Payment payment);
    Task<Payment> GetPaymentByIdAsync(int id);
}
}