using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using flightbookingproject2._0.Model;

namespace flightbookingproject2._0.RepositoryLayer.Interface
{
    public interface IPassengerRepository
    {
        Task<Passenger> AddPassengerAsync(Passenger passenger);
        Task<IEnumerable<Passenger>> GetAllPassengersAsync();
        Task<Passenger?> GetPassengerByIdAsync(int id);
        Task<bool> DeletePassengerAsync(int id);
    }
}
