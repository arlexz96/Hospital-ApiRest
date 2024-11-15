using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.Config;
using assesment.Models;
using Microsoft.EntityFrameworkCore;

namespace assesment.Seeders
{
    public class DoctorsSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { 
            Id = 1, 
            FirstName = "Juan", 
            LastName = "Pérez", 
            Email = "juan.perez@example.com", 
            IdentificationNumber = "123456789", 
            Password = Utilities.EncryptSHA256("doctor123"), 
            IdTypeDocument = 1, 
            IdRol = 2, // Assuming '2' is the role ID for doctors
            Available = true 
        },
        new Doctor { 
            Id = 2, 
            FirstName = "Ana", 
            LastName = "Gómez", 
            Email = "ana.gomez@example.com", 
            IdentificationNumber = "987654321", 
            Password = Utilities.EncryptSHA256("doctor456"), 
            IdTypeDocument = 1, 
            IdRol = 2, 
            Available = true 
        },
        new Doctor { 
            Id = 3, 
            FirstName = "Luis", 
            LastName = "Martínez", 
            Email = "luis.martinez@example.com", 
            IdentificationNumber = "112233445", 
            Password = Utilities.EncryptSHA256("doctor789"), 
            IdTypeDocument = 2, 
            IdRol = 2, 
            Available = false 
        },
        new Doctor { 
            Id = 4, 
            FirstName = "Isabel", 
            LastName = "López", 
            Email = "isabel.lopez@example.com", 
            IdentificationNumber = "334455667", 
            Password = Utilities.EncryptSHA256("doctor321"), 
            IdTypeDocument = 3, 
            IdRol = 2, 
            Available = true 
        },
        new Doctor { 
            Id = 5, 
            FirstName = "Carlos", 
            LastName = "Hernández", 
            Email = "carlos.hernandez@example.com", 
            IdentificationNumber = "998877665", 
            Password = Utilities.EncryptSHA256("doctor654"), 
            IdTypeDocument = 4, 
            IdRol = 2, 
            Available = false 
        }
            );
        }
    }
}