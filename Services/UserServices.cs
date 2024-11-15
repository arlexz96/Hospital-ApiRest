using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.Data;
using assesment.DTOs.Responses;
using assesment.Models;
using assesment.Repositories;
using Microsoft.EntityFrameworkCore;

namespace assesment.Services
{
    public class UserServices(AppDbContext appDbContext) : IUserRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<ICollection<UserResponseDTO>> GetUsers()
        {
            var users = await _appDbContext.Users
                .Include(u => u.TypeDocument)
                .Include(u => u.Rol)
                .Select(u => new UserResponseDTO
                {
                    Id = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Email = u.Email,
                    IdentificationNumber = u.IdentificationNumber,
                    TypeDocument = u.TypeDocument.Description,
                    Rol = u.Rol.Description
                })
                .ToListAsync();
            return users;
        }
        public async Task<UserResponseDTO> GetUserById(int id)
        {
            var user = await _appDbContext.Users
                .Include(u => u.TypeDocument)
                .Include(u => u.Rol)
                .Where(u => u.Id == id)
                .Select(u => new UserResponseDTO
                {
                    Id = u.Id,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Email = u.Email,
                    IdentificationNumber = u.IdentificationNumber,
                    TypeDocument = u.TypeDocument.Description,
                    Rol = u.Rol.Description
                })
                .FirstOrDefaultAsync();
            return user;
        }
        public async Task<ICollection<User>> FindUserByWord(string word)
        {
            var users = await _appDbContext.Users
                                .Where(u => u.FirstName.Contains(word) ||
                                            u.LastName.Contains(word) ||
                                            u.Email.Contains(word))
                                .ToListAsync();
            return users;
        }

        public async Task AddUser(User user)
        {
            await _appDbContext.Users.AddAsync(user);
            await _appDbContext.SaveChangesAsync();
        }
    }
}