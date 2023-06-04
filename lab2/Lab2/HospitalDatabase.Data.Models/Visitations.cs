using HospitalDatabase.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabase.Models
{
    public class Visitations : BaseEntity
    {
        [Key]
        public int VisitationId { get; set; }
        [MaxLength(250)]
        public string Comments { get; set; } = null!;
        public DateTime Date { get; set; }

      
        public int PatiendId { get; set; }
        public Patients patient { get; set; } = null!;
        public int DoctorId { get; set; } // Foreign key
        public Doctor doctor { get; set; } = null!;

    }
}
