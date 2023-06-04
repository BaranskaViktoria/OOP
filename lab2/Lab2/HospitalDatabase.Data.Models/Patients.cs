using HospitalDatabase.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabase.Models
{
    public class Patients : BaseEntity
    {
        [Key]
        public int PatientId { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; } = null!;
        [MaxLength(50)]
        public string LastName { get; set; } = null!;
        [MaxLength(250)]
        public string Address { get; set; } = null!;
        [MaxLength(80)]
        public string Email { get; set; } = null!;
        public bool HasInsurance { get; set; }

        public ICollection<Visitations> Visitations { get; set; } = new List<Visitations>();
        public ICollection<Diagnoses> Diagnoses { get; set; } = new List<Diagnoses>();
        public ICollection<PatientMedicamentcs> Prescriptions { get; set; } = new List<PatientMedicamentcs>();

    }
}
