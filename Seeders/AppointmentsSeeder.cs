using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.Models;
using Microsoft.EntityFrameworkCore;

namespace assesment.Seeders
{
    public class AppointmentsSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment
                {
                    Id = 1,
                    IdUser = 1,
                    IdUserDoctor = 1,
                    AppointmentDate = new DateTime(2024, 11, 20, 10, 0, 0),
                    Available = true,
                    Description = "General Checkup",
                    IdSpeciality = 1,
                    IdAppointmentReason = 1
                },

            new Appointment
            {
                Id = 2,
                IdUser = 2,
                IdUserDoctor = 2,
                AppointmentDate = new DateTime(2024, 11, 21, 14, 30, 0),
                Available = false,
                Description = "Dental Cleaning",
                IdSpeciality = 2,
                IdAppointmentReason = 2
            },

            new Appointment
            {
                Id = 3,
                IdUser = 3,
                IdUserDoctor = 3,
                AppointmentDate = new DateTime(2024, 11, 22, 9, 0, 0),
                Available = true,
                Description = "Cardiology Consultation",
                IdSpeciality = 3,
                IdAppointmentReason = 3
            },

            new Appointment
            {
                Id = 4,
                IdUser = 4,
                IdUserDoctor = 4,
                AppointmentDate = new DateTime(2024, 11, 23, 11, 0, 0),
                Available = true,
                Description = "Dermatology Checkup",
                IdSpeciality = 4,
                IdAppointmentReason = 4
            },

            new Appointment
            {
                Id = 5,
                IdUser = 5,
                IdUserDoctor = 5,
                AppointmentDate = new DateTime(2024, 11, 24, 16, 0, 0),
                Available = false,
                Description = "Eye Examination",
                IdSpeciality = 5,
                IdAppointmentReason = 5
            });
        }
    }
}