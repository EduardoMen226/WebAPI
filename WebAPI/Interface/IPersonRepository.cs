using WebAPI.Model;

namespace WebAPI.Interface
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetCustomersAsync();
    }
}
