using HospitalDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HospitalDatabase
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options) { }

        public DbSet<Patients> Patients => Set<Patients>();
        public DbSet<Visitations> Visitations => Set<Visitations>();
        public DbSet<Diagnoses> Diagnose => Set<Diagnoses>();
        public DbSet<Medicament> Medics => Set<Medicament>();
        public DbSet<PatientMedicamentcs> PatientMedicaments => Set<PatientMedicamentcs>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            Seeding.SeedingInit();

            modelBuilder.Entity<Doctor>().HasData(Seeding.Doctors);
        }

    }
}