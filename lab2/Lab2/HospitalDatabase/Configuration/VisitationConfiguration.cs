using HospitalDatabase.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabase.Configuration
{
    public class VisitationConfiguration : IEntityTypeConfiguration<Visitations>
    {
        public void Configure(EntityTypeBuilder<Visitations> builder)
        {
            builder.Property(v => v.Date);

            builder.Property(v => v.Comments)
                .HasMaxLength(250)
                .IsUnicode(true);

            builder.HasOne(v => v.Patient)
                .WithMany(p => p.Visitations)
                .HasForeignKey(v => v.PatientId);

            builder.HasOne(v => v.Doctor)
                .WithMany(d => d.Visitations)
                .HasForeignKey(v => v.DoctorId);
        }
    }
}
