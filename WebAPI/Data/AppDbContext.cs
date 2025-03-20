using Microsoft.EntityFrameworkCore;

using WebAPI.Model;

namespace WebAPI.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura el esquema y el nombre de la tabla
            modelBuilder.Entity<Person>().ToTable("Person", schema: "Person");
        }

        public DbSet<Person> Person { get; set; }
    }
}
