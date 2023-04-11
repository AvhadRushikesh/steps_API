using Microsoft.EntityFrameworkCore;
using steps_API.Model;

namespace steps_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
    }
}