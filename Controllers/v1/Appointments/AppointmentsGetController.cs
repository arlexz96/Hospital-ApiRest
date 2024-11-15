using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.Config;
using assesment.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace assesment.Controllers.v1.Appointments
{
    [ApiController]
    [Route("api/appointments")]
    [Tags("appointment")]
    public class AppointmentsGetController : AppointmentsController
    {
        public AppointmentsGetController(IAppointmentRepository appointmentRepository, Utilities utilities) : base(appointmentRepository, utilities)
        {
        }

        [HttpGet]
        [Authorize]
        [SwaggerOperation(
        Summary = "Retrieve all appointments",
        Description = "Retrieves a list of all appointments from the database."
    )]
        public async Task<IActionResult> GetAllAppointments()
        {
            var appointments = await _appointmentRepository.GetAllAppointments();
            if (appointments == null || !appointments.Any())
            {
                return NotFound("There are no appointments to show here");
            }
            return Ok(appointments);
        }

        [HttpGet("{id}")]
        [Authorize]
        [SwaggerOperation(
            Summary = "Get an appointment by its ID",
            Description = "This endpoint retrieves an appointment by its ID, along with its related data such as user, doctor, speciality, and appointment reason."
        )]
        public async Task<IActionResult> GetAppointmentById(int id)
        {
            var appointment = await _appointmentRepository.GetAppointmentById(id);

            if (appointment == null)
            {
                return NotFound("Appointment not found");
            }

            return Ok(appointment);
        }

        [HttpGet("search/{keyword}")]
        [Authorize]
        [SwaggerOperation(
            Summary = "Search for appointments by keyword",
            Description = "This endpoint allows searching appointments by a keyword. The search checks for matches in the description, user name, doctor name, and appointment reason."
        )]
        public async Task<IActionResult> GetAppointmentsByWord(string keyword)
        {
            var appointments = await _appointmentRepository.FindAppointmentByWord(keyword);

            if (appointments == null || !appointments.Any())
            {
                return NotFound("No appointments found matching the keyword");
            }

            return Ok(appointments);
        }

        [HttpGet("available")]
        [Authorize]
        [SwaggerOperation(
            Summary = "Retrieve all available appointments",
            Description = "Retrieves a list of all appointments that are marked as available."
        )]
        public async Task<IActionResult> GetAvailableAppointments()
        {
            var appointments = await _appointmentRepository.GetAvailableAppointments();
            if (appointments == null || !appointments.Any())
            {
                return NotFound("There are no available appointments to show here");
            }
            return Ok(appointments);
        }
    }
}