using Microsoft.EntityFrameworkCore;

namespace Mission06_Newell.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions<MoviesContext> options) : base (options) // constructor
        {
            
        }
        
        public DbSet<AddMovie> Movies { get; set; }
    }
}

