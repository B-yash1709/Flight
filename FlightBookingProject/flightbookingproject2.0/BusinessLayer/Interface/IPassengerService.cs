using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using flightbookingproject2._0.DTO;
using flightbookingproject2._0.Model;

namespace flightbookingproject2._0.BusinessLayer.Interface
{
    public interface IPassengerService
    {
        Task<Passenger> CreatePassengerAsync(PassengerDTO dto);
        Task<IEnumerable<Passenger>> GetAllPassengersAsync();
        Task<Passenger?> GetPassengerByIdAsync(int id);
        Task<bool> DeletePassengerAsync(int id);
    }
}