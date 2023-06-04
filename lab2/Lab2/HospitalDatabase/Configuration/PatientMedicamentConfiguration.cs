using HospitalDatabase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabase.Configuration
{
    public class PatientMedicamentConfiguration : IEntityTypeConfiguration<PatientMedicamentcs>
    {
        public void Configure(EntityTypeBuilder<PatientMedicamentcs> builder)
        {
            builder.HasKey(s => new { s.PatientId, s.MedicamentId });
            builder.HasOne(pm => pm.patient)
                           .WithMany(p => p.Prescriptions)
                           .HasForeignKey(pm => pm.PatientId);

            builder.HasOne(pm => pm.medicament)
                .WithMany(m => m.Prescriptions)
                .HasForeignKey(pm => pm.MedicamentId);
        }
    }
    
}
