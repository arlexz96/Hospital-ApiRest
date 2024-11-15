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
    public class DoctorsServices(AppDbContext appDbContext) : IDoctorRepository
    {
        private readonly AppDbContext _appDbContext = appDbContext;
        public async Task<ICollection<DoctorResponseDTO>> GetDoctors()
        {
            var doctors = await _appDbContext.Doctors
                .Include(d => d.TypeDocument)
                .Include(d => d.Rol)
                .Select(d => new DoctorResponseDTO
                {
                    Id = d.Id,
                    FirstName = d.FirstName,
                    LastName = d.LastName,
                    Email = d.Email,
                    IdentificationNumber = d.IdentificationNumber,
                    TypeDocument = d.TypeDocument.Description,
                    Rol = d.Rol.Description,
                    Available = d.Available
                })
                .ToListAsync();
            return doctors;
        }

        public async Task<DoctorResponseDTO> GetDoctorById(int id)
        {
            var doctor = await _appDbContext.Doctors
                .Include(d => d.TypeDocument)
                .Include(d => d.Rol)
                .Where(d => d.Id == id)
                .Select(d => new DoctorResponseDTO
                {
                    Id = d.Id,
                    FirstName = d.FirstName,
                    LastName = d.LastName,
                    Email = d.Email,
                    IdentificationNumber = d.IdentificationNumber,
                    TypeDocument = d.TypeDocument.Description,
                    Rol = d.Rol.Description,
                    Available = d.Available
                })
                .FirstOrDefaultAsync();

            return doctor;
        }

        public async Task<ICollection<Doctor>> FindDoctorByWord(string keyword)
        {
            var doctors = await _appDbContext.Doctors
                .Where(d => d.FirstName.Contains(keyword) ||
                            d.LastName.Contains(keyword) ||
                            d.Email.Contains(keyword))
                .ToListAsync();
            return doctors;
        }
        public async Task AddDoctor(Doctor doctor)
        {
            await _appDbContext.Doctors.AddAsync(doctor);
            await _appDbContext.SaveChangesAsync();
        }
    }
}