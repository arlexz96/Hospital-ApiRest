using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.Config;
using assesment.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace assesment.Controllers.v1.Doctors
{
    [ApiController]
    [Route("api/doctors")]
    [Tags("doctor")]
    public class DoctorsGetController : DoctorsController
    {
        public DoctorsGetController(IDoctorRepository doctorRepository, Utilities utilities) : base(doctorRepository, utilities)
        {
        }

        [HttpGet]
        [Authorize]
        [SwaggerOperation(
            Summary = "Retrieves all doctors from the system",
            Description = "Fetches a list of all doctors available in the system. If no doctors are found, a Not Found response is returned with a message indicating no doctors are available. If doctors are found, they are returned with a successful OK response."
        )]
        public async Task<IActionResult> GetAllDoctors()
        {
            var doctors = await _doctorRepository.GetDoctors();
            if (doctors == null || !doctors.Any())
            {
                return NotFound("There are no doctors to show here");
            }
            return Ok(doctors);
        }

        [HttpGet("{id}")]
        [Authorize]
        [SwaggerOperation(
            Summary = "Retrieve a doctor by their ID",
            Description = "Fetches the doctor details using the provided doctor ID. If no doctor is found with the specified ID, a 'Not Found' response with a message will be returned."
        )]
        public async Task<IActionResult> GetDoctorById(int id)
        {
            var doctor = await _doctorRepository.GetDoctorById(id);
            if (doctor == null)
            {
                return NotFound($"No doctor found with ID {id}");
            }
            return Ok(doctor);
        }

        [HttpGet("search/{keyword}")]
        [Authorize]
        [SwaggerOperation(
            Summary = "Search for doctors by keyword",
            Description = "Searches for doctors by matching the provided keyword against their first name, last name, or email. Returns a list of doctors who match the search criteria. If no doctors are found, a 'Not Found' response with a message will be returned."
        )]
        public async Task<IActionResult> GetDoctorByWord(string keyword)
        {
            var doctors = await _doctorRepository.FindDoctorByWord(keyword);
            if (!doctors.Any())
            {
                return NotFound("No doctor found");
            }
            return Ok(doctors);
        }
    }
}