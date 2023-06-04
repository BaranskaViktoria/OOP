using HospitalDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabase
{
    public class Seeding
    {
        public static List<Doctor> Doctors { get; set; } = new();

        public static void SeedingInit()
        {
            Doctors = new Faker<Doctor>()
                .RuleFor(x => x.Name, f => f.Person.FullName)
                .RuleFor(x => x.Speciality, f => f.Lorem.Word())
                .RuleFor(x => x.Login, f => f.Internet.Password())
                .RuleFor(x => x.Email, f => f.Internet.Email())
                .Generate(10);
        }
    }
}
}
