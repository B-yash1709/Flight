using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using flightbookingproject2._0.DTO;

namespace flightbookingproject2._0.BusinessLayer.Interface
{
    public interface IUserService
    {
        Task<UserDTO> GetUserByIdAsync(int id);
        Task<IEnumerable<UserDTO>> GetAllUsersAsync();
        Task<UserDTO> RegisterAsync(CreateUserDTO dto);
        Task<string> LoginAsync(LoginDTO dto);
    }
}