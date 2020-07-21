

using Microsoft.EntityFrameworkCore;

namespace PlanetDDS.Models.Patient
{
    public class PatientContext : DbContext
    {
        public PatientContext(DbContextOptions<PatientContext> options)
            : base(options)
        {
        }

        public DbSet<Patient> Patient { get; set; }
    }
}
