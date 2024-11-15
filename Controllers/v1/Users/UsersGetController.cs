using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.Config;
using assesment.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace assesment.Controllers.v1.Users
{
    [ApiController]
    [Route("api/v1/users")]
    [Tags("user")]
    public class UsersGetController : UsersController
    {
        public UsersGetController(IUserRepository userRepository, Utilities utilities) : base(userRepository, utilities)
        {
        }

        [HttpGet]
        [Authorize]
        [SwaggerOperation(
            Summary = "Briefly describes the method's purpose—retrieving all users",
            Description = "Explains the process in more detail, stating that if no users are found, a Not Found response is returned with a message, while if users are present, they are returned successfully."
        )]
        public async Task<IActionResult> GetAllUsers()
        {
            var Users = await _userRepository.GetUsers();
            if (Users == null || !Users.Any())
            {
                return NotFound("There are no guests to show here");
            }
            return Ok(Users);
        }
        [HttpGet("{id}")]
        [Authorize]
        [SwaggerOperation(
            Summary = "Retrieves a user by their ID",
            Description = "Fetches a user from the system based on the provided ID. If the user is not found, a Not Found response is returned with a message indicating that the user could not be found."
        )]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userRepository.GetUserById(id);
            if (user == null)
            {
                return NotFound($"User with ID {id} not found.");
            }
            return Ok(user);
        }

        [HttpGet("search/{keyword}")]
        [Authorize]
        [SwaggerOperation(
            Summary = "Search for users based on a keyword",
            Description = "Searches for users by matching the provided keyword against their first name, last name, or email. Returns a list of users who match the search criteria. If no users are found, a 'Not Found' response with a message will be returned."
        )]
        public async Task<IActionResult> GetUserByWord(string keyword)
        {
            var users = await _userRepository.FindUserByWord(keyword);
            if (!users.Any())
            {
                return NotFound("No user found");
            }
            return Ok(users);
        }
    }
}