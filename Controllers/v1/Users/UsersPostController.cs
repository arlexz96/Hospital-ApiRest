using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.Config;
using assesment.DTOs.Requests;
using assesment.Models;
using assesment.Repositories;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace assesment.Controllers.v1.Users
{
    [ApiController]
    [Route("api/v1/users")]
    [Tags("user")]
    public class UsersPostController : UsersController
    {
        public UsersPostController(IUserRepository userRepository, Utilities utilities) : base(userRepository, utilities)
        {
        }

        [HttpPost("register")]
        [SwaggerOperation(
            Summary = "Register a new user",
            Description = "This endpoint allows the registration of a new user. The password will be encrypted before storing it in the database. The user must provide first name, last name, email, identification number, password, document type, and role ID."
        )]
        public async Task<IActionResult> AddUser([FromBody] UserDTO userDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("User data is not valid");
            }

            // Encrypt the password
            userDTO.Password = Utilities.EncryptSHA256(userDTO.Password);

            // Create a User object from the DTO
            var userToAdd = new User
            {
                FirstName = userDTO.FirstName,
                LastName = userDTO.LastName,
                Email = userDTO.Email,
                IdentificationNumber = userDTO.IdentificationNumber,
                Password = userDTO.Password,
                IdTypeDocument = userDTO.IdTypeDocument,
                IdRol = userDTO.IdRol
            };

            // Add the user to the database
            await _userRepository.AddUser(userToAdd);

            return Ok("User registered successfully");
        }
    }
}