using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace assesment.Models
{
    [Table("appointments")]
    public class Appointment
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("id_user")]
        public int IdUser { get; set; }

        [ForeignKey("IdUser")]
        public virtual User User { get; set; }

        [Column("id_user_doctor")]
        public int IdUserDoctor { get; set; }

        [ForeignKey("IdUserDoctor")]
        public virtual User UserDoctor { get; set; }

        [Column("appointment_date")]
        public DateTime AppointmentDate { get; set; }

        [Column("available")]
        public bool Available { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("id_speciality")]
        public int IdSpeciality { get; set; }

        [ForeignKey("IdSpeciality")]
        public Speciality Speciality { get; set; }

        [Column("id_appointment_reasons")]
        public int IdAppointmentReason { get; set; }

        [ForeignKey("IdAppointmentReason")]
        public AppointmentReason AppointmentReason { get; set; }
    }
}