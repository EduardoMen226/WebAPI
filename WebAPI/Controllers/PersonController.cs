using Microsoft.AspNetCore.Mvc;
using WebAPI.Interface;
using WebAPI.Model;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {

        private readonly IPersonRepository _repository;

        public PersonController(IPersonRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Person>>> GetCustomer()
        {
            var customers = await _repository.GetCustomersAsync();
            return Ok(customers);
        }


    }
}
