using Microsoft.EntityFrameworkCore;

using WebAPI.Model;

namespace WebAPI.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Person> Person { get; set; }
    }
}
