using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.DTOs.Requests;
using assesment.Interfaces;
using assesment.Models;

namespace assesment.Repositories
{
    public interface IAuthRepository
    {
        public Task<IUser> Login(AuthDTO requestData);
    }
}