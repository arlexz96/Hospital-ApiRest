using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.Data;
using assesment.DTOs.Responses;
using assesment.Models;
using assesment.Repositories;
using Microsoft.EntityFrameworkCore;

namespace assesment.Services
{
    public class AppointmentServices : IAppointmentRepository
    {
        private readonly AppDbContext _appDbContext;

        public AppointmentServices(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<ICollection<AppointmentResponseDTO>> GetAllAppointments()
        {
            var appointments = await _appDbContext.Appointments
                .Include(a => a.User)
                .Include(a => a.UserDoctor)
                .Include(a => a.Speciality)
                .Include(a => a.AppointmentReason)
                .Select(a => new AppointmentResponseDTO
                {
                    Id = a.Id,
                    AppointmentDate = a.AppointmentDate,
                    Available = a.Available,
                    Description = a.Description,
                    UserName = a.User.FirstName + " " + a.User.LastName,
                    UserDoctorName = a.UserDoctor.FirstName + " " + a.UserDoctor.LastName,
                    SpecialityName = a.Speciality.Description,
                    AppointmentReasonDescription = a.AppointmentReason.Description
                })
                .ToListAsync();

            return appointments;
        }
        public async Task<AppointmentResponseDTO> GetAppointmentById(int id)
        {
            var appointment = await _appDbContext.Appointments
                .Include(a => a.User)
                .Include(a => a.UserDoctor)
                .Include(a => a.Speciality)
                .Include(a => a.AppointmentReason)
                .Where(a => a.Id == id)
                .FirstOrDefaultAsync();

            if (appointment == null)
            {
                return null; // O puedes lanzar una excepción si lo prefieres
            }

            // Mapea la entidad Appointment a AppointmentResponseDTO
            var appointmentResponse = new AppointmentResponseDTO
            {
                Id = appointment.Id,
                AppointmentDate = appointment.AppointmentDate,
                Available = appointment.Available,
                Description = appointment.Description,
                UserName = appointment.User.FirstName + " " + appointment.User.LastName,
                UserDoctorName = appointment.UserDoctor.FirstName + " " + appointment.UserDoctor.LastName,
                SpecialityName = appointment.Speciality.Description,
                AppointmentReasonDescription = appointment.AppointmentReason.Description
            };

            return appointmentResponse;
        }
        public async Task<ICollection<Appointment>> FindAppointmentByWord(string word)
        {
            return await _appDbContext.Appointments
                .Where(a => a.Description.Contains(word) || a.Description.Contains(word))
                .ToListAsync();
        }
        public async Task<ICollection<AppointmentResponseDTO>> GetAvailableAppointments()
        {
            var availableAppointments = await _appDbContext.Appointments
                .Include(a => a.User)
                .Include(a => a.UserDoctor)
                .Include(a => a.Speciality)
                .Include(a => a.AppointmentReason)
                .Where(a => a.Available == true) 
                .Select(a => new AppointmentResponseDTO
                {
                    AppointmentDate = a.AppointmentDate,
                    Available = a.Available,
                    Description = a.Description,
                    UserName = a.User.FirstName + " " + a.User.LastName,
                    UserDoctorName = a.UserDoctor.FirstName + " " + a.UserDoctor.LastName,  
                    SpecialityName = a.Speciality.Description, 
                    AppointmentReasonDescription = a.AppointmentReason.Description  
                })
                .ToListAsync();

            return availableAppointments;
        }
    }
}