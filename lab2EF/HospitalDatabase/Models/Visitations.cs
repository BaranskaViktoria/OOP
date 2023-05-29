using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabase.Models
{
    public class Visitations
    {
        [Key]
        public int VisitationId { get; set; }
        public string Comments { get; set; } = null!;
        public DateTime Date { get; set; }
      
        public int PatiendId { get; set; } 
 
    }
}
