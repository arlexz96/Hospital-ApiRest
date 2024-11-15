using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assesment.DTOs.Responses
{
    public class UserResponseDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string IdentificationNumber { get; set; }
        public string TypeDocument { get; set; }
        public string Rol { get; set; }
    }
}