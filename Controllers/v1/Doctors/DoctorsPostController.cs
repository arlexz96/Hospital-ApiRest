using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using assesment.Config;
using assesment.DTOs.Requests;
using assesment.Models;
using assesment.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace assesment.Controllers.v1.Doctors
{
    [ApiController]
    [Route("api/doctors")]
    [Tags("doctor")]
    public class DoctorsPostController : DoctorsController
    {
        public DoctorsPostController(IDoctorRepository doctorRepository, Utilities utilities) : base(doctorRepository, utilities)
        {
        }

        [HttpPost("register")]
        [SwaggerOperation(
            Summary = "Register a new doctor",
            Description = "This endpoint allows the registration of a new doctor. The password will be encrypted before storing it in the database. The doctor must provide first name, last name, email, identification number, password, and availability status."
        )]
        public async Task<IActionResult> AddDoctor([FromBody] DoctorDTO doctorDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Doctor data is not valid");
            }

            // Encrypt the password
            doctorDTO.Password = Utilities.EncryptSHA256(doctorDTO.Password);

            // Create a Doctor object from the DTO
            var doctorToAdd = new Doctor
            {
                FirstName = doctorDTO.FirstName,
                LastName = doctorDTO.LastName,
                Email = doctorDTO.Email,
                IdentificationNumber = doctorDTO.IdentificationNumber,
                Password = doctorDTO.Password,
                Available = doctorDTO.Available
            };

            // Add the doctor to the database
            await _doctorRepository.AddDoctor(doctorToAdd);

            return Ok("Doctor registered successfully");
        }

    }
}