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
    public class DiagnoseConfiguration : IEntityTypeConfiguration<Diagnoses>
    {
        public void Configure(EntityTypeBuilder<Diagnoses> builder)
        {
            builder.Property(d => d.Name)
                .HasMaxLength(50)
                .IsUnicode(true);

            builder.Property(d => d.Comments)
                .HasMaxLength(250)
                .IsUnicode(true);

            builder.HasOne(d => d.Patients)
                .WithMany(p => p.Diagnoses)
                .HasForeignKey(d => d.PatientId);
        }
    }
}