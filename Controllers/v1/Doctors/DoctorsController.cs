using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.Config;
using assesment.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace assesment.Controllers.v1.Doctors
{
    [ApiController]
    [Route("api/doctors")]
    [Tags("doctor")]
    public class DoctorsController(IDoctorRepository doctorRepository, Utilities utilities) : ControllerBase
    {
        protected readonly IDoctorRepository _doctorRepository = doctorRepository;
        protected readonly Utilities _utilities = utilities;
    }
}