using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.Models;
using assesment.Seeders;
using Microsoft.EntityFrameworkCore;

namespace assesment.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<TypeDocument> TypeDocuments { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<AppointmentReason> AppointmentReasons { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            RolesSeeder.Seed(modelBuilder);
            TypeDocumentsSeeder.Seed(modelBuilder);
            SpecialitiesSeeder.Seed(modelBuilder);
            AppointmentReasonsSeeder.Seed(modelBuilder);
            UsersSeed.Seed(modelBuilder);
            DoctorsSeed.Seed(modelBuilder);
            AppointmentsSeeder.Seed(modelBuilder);
        }
    }
}