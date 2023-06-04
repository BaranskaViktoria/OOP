using HospitalDatabase.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabase.Models
{
    public class PatientMedicamentcs : BaseEntity
    {
        public int PatientId { get; set; }
        public Patients patient { get; set; } = null!;

        public int MedicamentId { get; set; } // Foreign key
        public Medicament medicament { get; set; } = null!;
    }
}
