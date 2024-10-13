using Exir.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exir.Controlers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonRepository personRepository;
        private readonly IProfileRepository profileRepository;

        public PersonsController(IPersonRepository personRepository, IProfileRepository profileRepository)
        {
            this.personRepository = personRepository;
            this.profileRepository = profileRepository;
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var people = await personRepository.GetAllAsync();
            return Ok(people);
        }
    }
}
