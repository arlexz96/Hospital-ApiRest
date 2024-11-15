using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using assesment.Interfaces;

namespace assesment.Models
{
    [Table("users")]
    public class User : IUser
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("first_name")]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Column("last_name")]
        [StringLength(255)]
        public string LastName { get; set; }

        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }

        [Column("identification_number")]
        [StringLength(100)]
        public string IdentificationNumber { get; set; }

        [Column("password")]
        [StringLength(255)]
        public string Password { get; set; }

        [Column("id_type_document")]
        public int IdTypeDocument { get; set; }
        
        [ForeignKey("IdTypeDocument")]
        public TypeDocument TypeDocument { get; set; }

        [Column("id_rol")]
        public int IdRol { get; set; }

        [ForeignKey("IdRol")]
        public Rol Rol { get; set; }
    }
}