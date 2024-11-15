using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using assesment.Interfaces;

namespace assesment.Models
{
    [Table("doctors")]
    public class Doctor : IUser

    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Column("first_name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        [Column("last_name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(255)]
        [EmailAddress]
        [Column("email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        [Column("identification_number")]
        public string IdentificationNumber { get; set; }

        [Required]
        [StringLength(255)]
        [Column("password")]
        public string Password { get; set; }

        [Required]
        [Column("id_type_document")]
        public int IdTypeDocument { get; set; }  

        [Required]
        [Column("id_rol")]
        public int IdRol { get; set; }  

        [Required]
        [Column("available")]
        public bool Available { get; set; }  
        [ForeignKey("IdTypeDocument")]
        public TypeDocument TypeDocument { get; set; }

        [ForeignKey("IdRol")]
        public Rol Rol { get; set; }
    }

}