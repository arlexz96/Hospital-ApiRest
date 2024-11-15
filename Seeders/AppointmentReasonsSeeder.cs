using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.Models;
using Microsoft.EntityFrameworkCore;

namespace assesment.Seeders
{
    public class AppointmentReasonsSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppointmentReason>().HasData(
                new AppointmentReason { Id = 1, Description = "Revisión de salud general" },
                new AppointmentReason { Id = 2, Description = "Dolor en el pecho" },
                new AppointmentReason { Id = 3, Description = "Problemas respiratorios" },
                new AppointmentReason { Id = 4, Description = "Consulta de embarazo" },
                new AppointmentReason { Id = 5, Description = "Consulta de rutina para niños" },
                new AppointmentReason { Id = 6, Description = "Problemas de piel" },
                new AppointmentReason { Id = 7, Description = "Dolor de cabeza recurrente" },
                new AppointmentReason { Id = 8, Description = "Consulta dental" },
                new AppointmentReason { Id = 9, Description = "Problemas de visión" },
                new AppointmentReason { Id = 10, Description = "Ansiedad o problemas emocionales" }
            );
        }
        
    }
}