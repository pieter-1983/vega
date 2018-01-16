using Microsoft.EntityFrameworkCore;
using vega.Models;

namespace vega.DataBase
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
        : base(options)
        { }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=vega;user=aap;password=aap");
        }
    }
}