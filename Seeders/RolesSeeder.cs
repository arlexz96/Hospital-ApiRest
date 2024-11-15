using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.Models;
using Microsoft.EntityFrameworkCore;

namespace assesment.Seeders
{
    public class RolesSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rol>().HasData(
                new Rol { Id = 1, Description = "Administrador" },
                new Rol { Id = 2, Description = "Médico" },
                new Rol { Id = 3, Description = "Usuario" }
            );
        }
    }
}