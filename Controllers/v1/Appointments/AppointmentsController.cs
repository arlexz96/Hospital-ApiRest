using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.Config;
using assesment.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace assesment.Controllers.v1.Appointments
{
    [ApiController]
    [Route("api/appointments")]
    [Tags("appointment")]
    public class AppointmentsController(IAppointmentRepository appointmentRepository, Utilities utilities) : ControllerBase
    {
        protected readonly IAppointmentRepository _appointmentRepository = appointmentRepository;
        protected readonly Utilities _utilities = utilities;
    }
}