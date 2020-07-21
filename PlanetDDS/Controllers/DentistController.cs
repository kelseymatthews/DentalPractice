using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlanetDDS.Models;

namespace PlanetDDS.Controllers
{
    [ApiController]
    [Route("dentist")]
    public class DentistController : ControllerBase
    {
        private readonly PracticeContext _context;

        public DentistController(PracticeContext context)
        {
            _context = context;
        }

        [HttpGet()]
        public IEnumerable<Dentist> GetDentists()
        {
            return _context.Dentist;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Dentist>> GetDentistByID(int id)
        {
            var dentist = await _context.Dentist.FindAsync(id);

            if (dentist == null)
            {
                return NotFound();
            }

            return dentist;
        }
    }
}