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
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.Property(d => d.FirstName)
              .HasMaxLength(100)
              .IsUnicode(true);

            builder.Property(d => d.Speciality)
                .HasMaxLength(100)
                .IsUnicode(true);

            builder.Property(d => d.Login)
                .HasMaxLength(20);

            builder.Property(d => d.Email)
                .HasMaxLength(50);
        }
    }
}
