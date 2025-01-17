using Microsoft.AspNetCore.Mvc;

namespace FIAP.TechChallenge.ByteMeBurger.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        // GET: api/<SampleController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SampleController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SampleController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SampleController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SampleController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
