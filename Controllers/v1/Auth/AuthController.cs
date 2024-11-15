using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using assesment.Config;
using assesment.DTOs.Requests;
using assesment.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace assesment.Controllers.v1.Auth
{
    [Route("api/v1/auth")]
    [Tags("auth")]
    public class AuthController(IAuthRepository authRepository, Utilities utilities) : Controller
    {
        protected readonly IAuthRepository _authRepository = authRepository;
        protected readonly Utilities _utilities = utilities;
        [HttpPost("login")]
        [SwaggerOperation(
            Summary = "Authenticates a user or doctor based on email and password",
            Description = "Expands on how the method validates the data, encrypts the password, attempts to authenticate the user, and returns a token upon success. It also mentions that if the data is invalid, a BadRequest response is returned"
        )]
        public async Task<IActionResult> Login(AuthDTO authDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Data is no valid");
            }
            authDTO.Password = Utilities.EncryptSHA256(authDTO.Password);
            var User = await _authRepository.Login(authDTO);
            var Token = _utilities.GenerateJwtToken(User);
            return Ok(new{
                Message = "Token has been generated successfully",
                token = Token
            });
        }
    }
}