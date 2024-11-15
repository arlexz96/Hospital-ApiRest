using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assesment.DTOs.Requests
{
    public class DoctorDTO
    {
        [Required(ErrorMessage = "First Name is required")]
        [MaxLength(255, ErrorMessage = "The field First Name cannot exceed 255 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [MaxLength(255, ErrorMessage = "The field Last Name cannot exceed 255 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [MaxLength(255, ErrorMessage = "The field Email cannot exceed 255 characters")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Identification Number is required")]
        [MaxLength(20, ErrorMessage = "The field Identification Number cannot exceed 20 characters")]
        public string IdentificationNumber { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MaxLength(255, ErrorMessage = "The field Password cannot exceed 255 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Specialty is required")]
        public string Specialty { get; set; }

        [Required(ErrorMessage = "Available is required")]
        public bool Available { get; set; }

    }
}