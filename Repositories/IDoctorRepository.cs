using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assesment.DTOs.Responses;
using assesment.Models;

namespace assesment.Repositories
{
    public interface IDoctorRepository
    {
        public Task<ICollection<DoctorResponseDTO>> GetDoctors();
        public Task<DoctorResponseDTO> GetDoctorById(int id);
        public Task<ICollection<Doctor>> FindDoctorByWord(string keyword);
        public Task AddDoctor(Doctor doctor);
    }
}