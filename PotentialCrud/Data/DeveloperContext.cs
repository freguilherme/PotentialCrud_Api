using Microsoft.EntityFrameworkCore;

namespace PotentialCrud.Data
{
    public class DeveloperContext : DbContext
    {
        public DeveloperContext(DbContextOptions<DeveloperContext> options) : base(options) { }
        public DbSet<Developer> developers { get; set; }
    }
}
