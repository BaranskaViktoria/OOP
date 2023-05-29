using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabase.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; } = null!;
        [MaxLength(100)]
        public string LastName { get; set; } = null!;
        [MaxLength(100)]
        public string Specialty { get; set; } = null!;
    }
}
