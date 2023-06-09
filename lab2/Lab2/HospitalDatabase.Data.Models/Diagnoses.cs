﻿using HospitalDatabase.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabase.Models
{
    public class Diagnoses : BaseEntity
    {
        [Key]
        public int DiagnoseId { get; set; }
        [MaxLength(50)]
        public string Comments { get; set; } = null!;
        public string Name { get; set; }
        public int PatiendId { get; set; } // Foreign key
        public Patients patient { get; set; } = null!;

    }
}
