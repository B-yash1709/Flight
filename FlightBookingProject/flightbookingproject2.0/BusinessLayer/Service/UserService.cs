using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using flightbookingproject2._0.BusinessLayer.Interface;
using flightbookingproject2._0.DTO;
using flightbookingproject2._0.Helper.JWTServices;
using flightbookingproject2._0.Model;
using flightbookingproject2._0.RepositoryLayer.Interface;

namespace flightbookingproject2._0.BusinessLayer.Service
{
    public class UserService : IUserService
    {
        private readonly JWTServices _jwtServices;
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository, JWTServices jwtServices)
        {
            _userRepository = userRepository;
            _jwtServices = jwtServices;
        }

        public async Task<UserDTO> GetUserByIdAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);

            return new UserDTO
            {
                FullName = user.FullName,
                Email = user.Email
            };
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllAsync();
            var userDTOs = new List<UserDTO>();

            foreach (var user in users)
            {
                userDTOs.Add(new UserDTO
                {
                    FullName = user.FullName,
                    Email = user.Email
                });
            }

            return userDTOs;
        }

        public async Task<UserDTO> RegisterAsync(CreateUserDTO dto)
        {
            var existing = await _userRepository.GetByEmailAsync(dto.Email);
            if (existing != null)
                throw new Exception("Email already exists");

            var user = new User
            {
                FullName = dto.FullName,
                Email = dto.Email,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(dto.Password),
                Role = dto.Role
            };

            await _userRepository.AddAsync(user);

            return new UserDTO
            {
                FullName = user.FullName,
                Email = user.Email
            };
        }

        public async Task<string> LoginAsync(LoginDTO dto)
        {
            var user = await _userRepository.GetByEmailAsync(dto.Email);
            if (user == null || !BCrypt.Net.BCrypt.Verify(dto.Password, user.PasswordHash))
                throw new Exception("Invalid credentials");

            return _jwtServices.GenerateToken(user);
        }
    }
}
