using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace flightbookingproject2._0.DTO
{
    public class CreateUserDTO
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public string Role { get; set; } = "Customer";
    }
}