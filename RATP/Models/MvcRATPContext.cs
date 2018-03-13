using Microsoft.EntityFrameworkCore;

namespace RATP.Models
{
    public class MvcRATPContext : DbContext
    {
        public MvcRATPContext (DbContextOptions<MvcRATPContext> options)
            : base(options)
        {
        }

        public DbSet<RATP.Models.Line> Line { get; set; }
        public DbSet<RATP.Models.Station> Station { get; set; }
    }
}