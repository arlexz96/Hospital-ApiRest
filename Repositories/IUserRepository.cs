using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.DTOs.Responses;
using assesment.Models;

namespace assesment.Repositories
{
    public interface IUserRepository
    {
        public Task<ICollection<UserResponseDTO>> GetUsers();
        public Task<UserResponseDTO> GetUserById(int id);
        public Task<ICollection<User>> FindUserByWord(string word);
        public Task AddUser(User user);
    }
}