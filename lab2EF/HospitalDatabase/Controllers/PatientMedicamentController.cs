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

    [Route("ef/patient-medicament")]
    [ApiController]
    public class PatientMedicamentController : ControllerBase
    {
        private readonly IPatientMedicamentRepository patientMedicamentRepository;

        public PatientMedicamentController(IPatientMedicamentRepository patientMedicamentRepository)
        {
            this.patientMedicamentRepository = patientMedicamentRepository;
        }


        // GET: ef/patient-medicament
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<PatientMedicament> patientsMedicaments = patientMedicamentRepository.GetAll();
            return Ok(patientsMedicaments);
        }

        // GET: ef/patient-medicament/5
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            PatientMedicamentcs? patientMedicament = patientMedicamentRepository.Get(id);
            if (patientMedicament == null)
                return NotFound("The Patient-Medicament record couldn't be found.");

            return Ok(patientMedicament);
        }

        // POST: ef/patient-medicament
        [HttpPost]
        public IActionResult Post(PatientMedicament patientMedicament)
        {
            if (patientMedicament == null)
                return BadRequest("Patient-Medicament is null.");

            patientMedicamentRepository.Add(patientMedicament);

            return CreatedAtRoute(
                  "Get",
                  new
                  {
                      patientId = patientMedicament.PatientId,
                      medicamentId = patientMedicament.MedicamentId
                  },
                  patientMedicament);
        }

        // PUT: ef/patient-medicament/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, PatientMedicament patientMedicament)
        {
            if (patientMedicament == null)
                return BadRequest("Patient-Medicament is null.");

            PatientMedicament? patientMedicamentToUpdate = patientMedicamentRepository.Get(id);

            if (patientMedicamentToUpdate == null)
                return NotFound("The Patient-Medicament record couldn't be found.");

            patientMedicamentRepository.Update(patientMedicamentToUpdate, patientMedicament);
            return NoContent();
        }

        // DELETE: ef/patient-medicament/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            PatientMedicament? patientMedicament = patientMedicamentRepository.Get(id);

            if (patientMedicament == null)
                return NotFound("The Patient-Medicament record couldn't be found.");

            patientMedicamentRepository.Delete(patientMedicament);
            return NoContent();
        }
    }
}