using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.DTOs.Responses;
using assesment.Models;

namespace assesment.Repositories
{
    public interface IAppointmentRepository
    {
        public Task<ICollection<AppointmentResponseDTO>> GetAllAppointments();
        public Task<AppointmentResponseDTO> GetAppointmentById(int id);
        public Task<ICollection<Appointment>> FindAppointmentByWord(string word);
        public Task<ICollection<AppointmentResponseDTO>> GetAvailableAppointments();
    }
}