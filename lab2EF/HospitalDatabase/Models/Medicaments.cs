using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabase
{
    public class Medicaments
    {
        [Key]
        public int MedicamentId { get; set; }
        public string? Name { get; set; } = null!;
    }
}
