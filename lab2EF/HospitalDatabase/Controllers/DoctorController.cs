using HospitalDatabase.Models;
using HospitalDatabase.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabase.Controllers
{
    [Route("ef/doctor")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository doctorRepository;

        public DoctorController(IDoctorRepository doctorRepository)
        {
            this.doctorRepository = doctorRepository;
        }


        // GET: ef/doctor
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Doctor> doctors = doctorRepository.GetAll();
            return Ok(doctors);
        }

        // GET: ef/doctor/5
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            Doctor? doctor = doctorRepository.Get(id);
            if (doctor == null)
                return NotFound("The Doctor record couldn't be found.");

            return Ok(doctor);
        }

        // POST: ef/doctor
        [HttpPost]
        public IActionResult Post(Doctor doctor)
        {
            if (doctor == null)
                return BadRequest("Doctor is null.");

            doctorRepository.Add(doctor);

            return CreatedAtRoute(
                  "Get",
                  new { Id = doctor.DoctorId },
                  doctor);
        }

        // PUT: ef/doctor/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, Doctor doctor)
        {
            if (doctor == null)
                return BadRequest("Doctor is null.");

            Doctor? doctorToUpdate = doctorRepository.Get(id);

            if (doctorToUpdate == null)
                return NotFound("The Doctor record couldn't be found.");

            doctorRepository.Update(doctorToUpdate, doctor);
            return NoContent();
        }

        // DELETE: ef/doctor/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Doctor? doctor = doctorRepository.Get(id);

            if (doctor == null)
                return NotFound("The Doctor record couldn't be found.");

            doctorRepository.Delete(doctor);
            return NoContent();
        }
    }
}
