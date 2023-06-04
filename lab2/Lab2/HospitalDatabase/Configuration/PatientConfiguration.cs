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
    public class PatientConfiguration : IEntityTypeConfiguration<Patients>
    {
        public void Configure(EntityTypeBuilder<Patients> builder)
        {
            builder.Property(p => p.FirstName)
                .HasMaxLength(50)
                .IsUnicode(true);

            builder.Property(p => p.LastName)
                .HasMaxLength(50)
                .IsUnicode(true);

            builder.Property(p => p.Address)
                .HasMaxLength(250)
                .IsUnicode(true);

            builder.Property(p => p.Address)
                .HasMaxLength(80)
                .IsUnicode(false);

            builder.Property(p => p.HasInsurance);
        }
    }
}
