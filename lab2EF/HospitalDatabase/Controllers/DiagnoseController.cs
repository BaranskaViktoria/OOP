using HospitalDatabase.Models;
using HospitalDatabase.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using HospitalDatabase.Repository;
using System.Threading.Tasks;

namespace HospitalDatabase.Controllers
{

        [Route("ef/diagnoses")]
        [ApiController]
        public class DiagnoseController : ControllerBase
        {
            private readonly IDiagnoseRepository diagnoseRepository;

            public DiagnoseController(IDiagnoseRepository diagnoseRepository)
            {
                this.diagnoseRepository = diagnoseRepository;
            }


            // GET: ef/diagnose
            [HttpGet]
            public IActionResult Get()
            {
                IEnumerable<Diagnoses> diagnoses = diagnoseRepository.GetAll();
                return Ok(diagnoses);
            }

            // GET: ef/diagnose/5
            [HttpGet("{id}")]
            public IActionResult Get(long id)
            {
                Diagnoses? diagnose = diagnoseRepository.Get(id);
                if (diagnose == null)
                    return NotFound("The Diagnose record couldn't be found.");

                return Ok(diagnose);
            }

            // POST: ef/diagnose
            [HttpPost]
            public IActionResult Post(Diagnoses diagnose)
            {
                if (diagnose == null)
                    return BadRequest("Diagnose is null.");

                diagnoseRepository.Add(diagnose);

                return CreatedAtRoute(
                      "Get",
                      new { Id = diagnose.DiagnoseId },
                      diagnose);
            }

            // PUT: ef/diagnose/5
            [HttpPut("{id}")]
            public IActionResult Put(long id, Diagnoses diagnose)
            {
                if (diagnose == null)
                    return BadRequest("Diagnose is null.");

                Diagnoses? diagnoseToUpdate = diagnoseRepository.Get(id);

                if (diagnoseToUpdate == null)
                    return NotFound("The Diagnose record couldn't be found.");

                diagnoseRepository.Update(diagnoseToUpdate, diagnose);
                return NoContent();
            }

            // DELETE: ef/diagnose/5
            [HttpDelete("{id}")]
            public IActionResult Delete(long id)
            {
                Diagnoses? diagnose = diagnoseRepository.Get(id);

                if (diagnose == null)
                    return NotFound("The Diagnose record couldn't be found.");

                diagnoseRepository.Delete(diagnose);
                return NoContent();
            }
        }
}
