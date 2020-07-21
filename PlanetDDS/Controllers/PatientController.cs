using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlanetDDS.Models;

namespace PlanetDDS.Controllers
{
    [ApiController]
    [Route("patient")]
    public class PatientController : ControllerBase
    {
        private readonly PracticeContext _context;

        public PatientController(PracticeContext context)
        {
            _context = context;
        }

        [HttpGet()]
        public IEnumerable<Patient> GetPatients()
        {
            return _context.Patient;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetPatientByID(int id)
        {
            var patient = await _context.Patient.FindAsync(id);

            if (patient == null)
            {
                return NotFound();
            }

            return patient;
        }
    }
}
