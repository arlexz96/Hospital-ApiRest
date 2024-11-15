using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.Models;
using Microsoft.EntityFrameworkCore;

namespace assesment.Seeders
{
    public class TypeDocumentsSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypeDocument>().HasData(
                new TypeDocument { Id = 1, Description = "Pasaporte" },
                new TypeDocument { Id = 2, Description = "Licencia de Conducir" },
                new TypeDocument { Id = 3, Description = "Cédula de Identidad" },
                new TypeDocument { Id = 4, Description = "Número de Seguridad Social" },
                new TypeDocument { Id = 5, Description = "Certificado de Nacimiento" }
            );
        }
    }
}