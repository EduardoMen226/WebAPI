using Microsoft.EntityFrameworkCore;
using WebAPI.Entities;
using WebAPI.Model;

namespace WebAPI.Data
{
    public class PersonRepository : ICustomerRepository
    {
        private readonly AppDbContext _context;

        public PersonRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Person> GetCustomerByIdAsync(int id)
            => await _context.Person.FindAsync(id);

        public async Task<IEnumerable<Person>> GetCustomersAsync()
            => await _context.Person.Take(100).ToListAsync();

        public async Task<Person> CreateCustomerAsync(Person person)
        {
            _context.Person.Add(person);
            await _context.SaveChangesAsync();
            return person;
        }
    }

    public interface ICustomerRepository
    {
    }
}
