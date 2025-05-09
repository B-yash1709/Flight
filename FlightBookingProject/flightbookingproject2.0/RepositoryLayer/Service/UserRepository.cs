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
   public class UserRepository : IUserRepository
    {
        private readonly FlightBookingDbContext _context;

        public UserRepository(FlightBookingDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetByIdAsync(int id) => await _context.Users.FindAsync(id);

        public async Task<User> GetByEmailAsync(string email) =>
            await _context.Users.FirstOrDefaultAsync(u => u.Email == email);

        public async Task<IEnumerable<User>> GetAllAsync() => await _context.Users.ToListAsync();

        public async Task AddAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }
    }

}