using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assesment.DTOs.Responses
{
    public class AppointmentResponseDTO
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }
        public bool Available { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }
        public string UserDoctorName { get; set; }
        public string SpecialityName { get; set; }
        public string AppointmentReasonDescription { get; set; }
    }
}