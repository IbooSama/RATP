using Microsoft.EntityFrameworkCore;

namespace RATP.Models
{
    public class MvcLineContext : DbContext
    {
        public MvcLineContext(DbContextOptions<MvcLineContext> options)
            : base(options)
        {
        }

        public DbSet<RATP.Models.Line> Line { get; set; }
    }
}