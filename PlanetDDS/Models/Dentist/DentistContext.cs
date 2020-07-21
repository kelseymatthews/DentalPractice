
using Microsoft.EntityFrameworkCore;

namespace PlanetDDS.Models.Dentist
{
    public class DentistContext : DbContext
    {
        public DentistContext(DbContextOptions<DentistContext> options)
            : base(options)
        {
        }

        public DbSet<Dentist> Dentist { get; set; }
    }
}
