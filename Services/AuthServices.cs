using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.Data;
using assesment.DTOs.Requests;
using assesment.Interfaces;
using assesment.Models;
using assesment.Repositories;
using Microsoft.EntityFrameworkCore;


namespace assesment.Services
{
    public class AuthServices : IAuthRepository
    {
        private readonly AppDbContext _appDbContext;
        public AuthServices(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IUser> Login(AuthDTO requestData)
        {
            var User = await _appDbContext.Users.FirstOrDefaultAsync(e => e.Email == requestData.Email);
            if (User == null)
            {
                var UserD = await _appDbContext.Doctors.FirstOrDefaultAsync(e => e.Email == requestData.Email);
                if (UserD == null)
                    throw new Exception(" User doesn't exist ");
                if (UserD.Password != requestData.Password)
                {
                    throw new Exception(" User Email or Password is not correct ");
                }
                return UserD;
            }
            if (User.Password != requestData.Password)
            {
                throw new Exception(" User Email or Password is not correct ");
            }
            return User;
        }
    }
}