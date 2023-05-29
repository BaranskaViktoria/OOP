using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabase.Models
{
    public class PatientMedicamentcs
    {
        public int PatientId { get; set; }

        public int MedicamentId { get; set; } // Foreign key
    }
}
