using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.Config;
using assesment.Models;
using Microsoft.EntityFrameworkCore;

namespace assesment.Seeders
{
    public class UsersSeed()
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FirstName = "Juan", LastName = "Pérez", Email = "juan@example.com", IdentificationNumber = "123456789", Password = Utilities.EncryptSHA256("password12"), IdTypeDocument = 1, IdRol = 3 },
                new User { Id = 2, FirstName = "Ana", LastName = "Gómez", Email = "ana@example.com", IdentificationNumber = "987654321", Password = Utilities.EncryptSHA256("password456"), IdTypeDocument = 1, IdRol = 3 },
                new User { Id = 3, FirstName = "Luis", LastName = "Martínez", Email = "luis@example.com", IdentificationNumber = "112233445", Password = Utilities.EncryptSHA256("password78"), IdTypeDocument = 2, IdRol = 3 },
                new User { Id = 4, FirstName = "Marta", LastName = "Rodríguez", Email = "marta@example.com", IdentificationNumber = "556677889", Password = Utilities.EncryptSHA256("password9"), IdTypeDocument = 3, IdRol = 3 },
                new User { Id = 5, FirstName = "Carlos", LastName = "Hernández", Email = "carlos@example.com", IdentificationNumber = "998877665", Password = Utilities.EncryptSHA256("password13"), IdTypeDocument = 4, IdRol = 3 },
                new User { Id = 6, FirstName = "Roberto", LastName = "Suárez", Email = "roberto@example.com", IdentificationNumber = "223344556", Password = Utilities.EncryptSHA256("password124"), IdTypeDocument = 1, IdRol = 3 },
                new User { Id = 7, FirstName = "Isabel", LastName = "López", Email = "isabel@example.com", IdentificationNumber = "334455667", Password = Utilities.EncryptSHA256("password126"), IdTypeDocument = 2, IdRol = 3 },
                new User { Id = 8, FirstName = "Juan", LastName = "García", Email = "juan2@example.com", IdentificationNumber = "445566778", Password = Utilities.EncryptSHA256("password127"), IdTypeDocument = 3, IdRol = 3 },
                new User { Id = 9, FirstName = "Teresa", LastName = "Fernández", Email = "teresa@example.com", IdentificationNumber = "556677889", Password = Utilities.EncryptSHA256("password128"), IdTypeDocument = 4, IdRol = 3 },
                new User { Id = 10, FirstName = "Admin", LastName = "Admin", Email = "admin@example.com", IdentificationNumber = "123123123", Password = Utilities.EncryptSHA256("admin120"), IdTypeDocument = 1, IdRol = 1 }
            );
        }
    }
}