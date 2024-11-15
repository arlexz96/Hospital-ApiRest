using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.Models;
using Microsoft.EntityFrameworkCore;

namespace assesment.Seeders
{
    public class SpecialitiesSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Speciality>().HasData(
                new Speciality { Id = 1, Description = "Cardiología" },
                new Speciality { Id = 2, Description = "Pediatría" },
                new Speciality { Id = 3, Description = "Ginecología" },
                new Speciality { Id = 4, Description = "Dermatología" },
                new Speciality { Id = 5, Description = "Oftalmología" },
                new Speciality { Id = 6, Description = "Medicina General" },
                new Speciality { Id = 7, Description = "Neurología" },
                new Speciality { Id = 8, Description = "Traumatología" },
                new Speciality { Id = 9, Description = "Odontología" },
                new Speciality { Id = 10, Description = "Psiquiatría" }
            );
        }
    }
}