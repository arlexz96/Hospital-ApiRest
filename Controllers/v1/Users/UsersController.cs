using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.Config;
using assesment.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace assesment.Controllers.v1.Users
{
    [ApiController]
    [Route("api/v1/users")]
    [Tags("user")]
    public class UsersController(IUserRepository userRepository, Utilities utilities) : ControllerBase
    {
        protected readonly IUserRepository _userRepository = userRepository;
        protected readonly Utilities _utilities = utilities;
    }
}