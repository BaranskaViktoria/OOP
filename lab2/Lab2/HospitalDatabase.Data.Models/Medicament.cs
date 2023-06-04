using HospitalDatabase.Data.Models;
using HospitalDatabase.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabase
{
    public class Medicament : BaseEntity
    {
        [Key]
        public int MedicamentId { get; set; }
        public string? Name { get; set; } = null!;
        public object Prescriptions { get; set; }

        //    public ICollection<PatientMedicament> Prescriptions { get; set; } = new List<PatientMedicament>();
    }
}
