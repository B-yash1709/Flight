using flightbookingproject2._0.BusinessLayer.Interface;
using flightbookingproject2._0.DTO;
using flightbookingproject2._0.Model;
using flightbookingproject2._0.RepositoryLayer.Interface;


namespace flightbookingproject2._0.BusinessLayer.Service
{
    
    public class PassengerService : IPassengerService
    {
        private readonly IPassengerRepository _passengerRepo;

        public PassengerService(IPassengerRepository passengerRepo)
        {
            _passengerRepo = passengerRepo;
        }

        public async Task<Passenger> CreatePassengerAsync(PassengerDTO dto)
        {
            var passenger = new Passenger
            {
                FullName = dto.FullName,
                Age = dto.Age,
                Gender = dto.Gender,
                BookingId = dto.BookingId
            };

            return await _passengerRepo.AddPassengerAsync(passenger);
        }

        public async Task<IEnumerable<Passenger>> GetAllPassengersAsync()
        {
            return await _passengerRepo.GetAllPassengersAsync();
        }

        public async Task<Passenger?> GetPassengerByIdAsync(int id)
        {
            return await _passengerRepo.GetPassengerByIdAsync(id);
        }

        public async Task<bool> DeletePassengerAsync(int id)
        {
            return await _passengerRepo.DeletePassengerAsync(id);
        }
    }
}
