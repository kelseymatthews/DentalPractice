
using Microsoft.EntityFrameworkCore;


namespace PlanetDDS.Models
{
    public class PracticeContext : DbContext
    {
        public PracticeContext(DbContextOptions<PracticeContext> options)
            : base(options)
        {
        }

        public DbSet<Dentist> Dentist { get; set; }

        public DbSet<Patient> Patient { get; set; }
    }
}