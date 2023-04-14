using mentoring_system.model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apimentoringsystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mentorController : ControllerBase
    {
        List<mentor> mentorData = new List<mentor>();
        // GET: api/<mentorController>
        [HttpGet]
        public IEnumerable<mentor> Get()
        {
            return mentorData;
        }

        // GET api/<mentorController>/5
        [HttpGet("{id}")]
        public mentor Get(int id)
        {
            return mentorData[id];
        }

        // POST api/<mentorController>
        [HttpPost]
        public void Post([FromBody] mentor value)
        {
            mentorData.Add(value);
        }

        // PUT api/<mentorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            mentorData[id].Equals(value);
        }

        // DELETE api/<mentorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            mentorData.RemoveAt(id);
        }
    }
}
