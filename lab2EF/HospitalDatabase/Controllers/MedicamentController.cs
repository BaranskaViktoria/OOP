using HospitalDatabase.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDatabase.Controllers
{
    [Route("ef/medicament")]
    [ApiController]
    public class MedicamentController : ControllerBase
    {
        private readonly IMedicamentRepository medicamentRepository;

        public MedicamentController(IMedicamentRepository medicamentRepository)
        {
            this.medicamentRepository = medicamentRepository;
        }


        // GET: ef/medicament
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Medicaments> medicament = medicamentRepository.GetAll();
            return Ok(medicament);
        }

        // GET: ef/medicament/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Medicaments? medicament = medicamentRepository.Get(id);
            if (medicament == null)
                return NotFound("The Medicament record couldn't be found.");

            return Ok(medicament);
        }

        // POST: ef/medicament
        [HttpPost]
        public IActionResult Post(Medicaments medicament)
        {
            if (medicament == null)
                return BadRequest("Medicaments is null.");

            medicamentRepository.Add(medicament);

            return CreatedAtRoute(
                  "Get",
                  new { Id = medicament.MedicamentId },
                  medicament);
        }

        // PUT: ef/medicament/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, Medicaments medicament)
        {
            if (medicament == null)
                return BadRequest("Medicaments is null.");

            Medicaments? medicamentToUpdate = medicamentRepository.Get(id);

            if (medicamentToUpdate == null)
                return NotFound("The Medicaments record couldn't be found.");

            medicamentRepository.Update(medicamentToUpdate, medicament);
            return NoContent();
        }

        // DELETE: ef/medicament/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Medicaments? medicament = medicamentRepository.Get(id);

            if (medicament == null)
                return NotFound("The Medicaments record couldn't be found.");

            medicamentRepository.Delete(medicament);
            return NoContent();
        }
    }
}