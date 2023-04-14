using mentoring_system.model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apimentoringsystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
public class mentorshipController : ControllerBase
{
        public static List<genericsMentorship<string>> mentorship = new List<genericsMentorship<string>>();
    // GET: api/<mentorshipController>
    [HttpGet]
    public IEnumerable<genericsMentorship<string>> Get()
    {
        return mentorship;
    }

    // GET api/<mentorshipController>/5
    [HttpGet("{id}")]
    public genericsMentorship<string>? Get(int id)
    {
            for (int i = 0; i < mentorship.Count; i++)
            {
                if (    mentorship[i].Id == id)
                {
                    return mentorship[i];
                }
            }
            return null;
        }

    // POST api/<mentorshipController>
    [HttpPost]
    public void Post([FromBody] genericsMentorship<string> value)
    {
            mentorship.Add(value);
    }

    // PUT api/<mentorshipController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] genericsMentorship<string> value)
    {
            for (int i = 0; i < mentorship.Count; i++)
            {
                if (mentorship[i].Id == id)
                {
                    mentorship[i] = value;
                }
            }
        }

    // DELETE api/<mentorshipController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
            for (int i = 0; i < mentorship.Count; i++)
            {
                if (mentorship[i].Id == id)
                {
                    mentorship.RemoveAt(i);
                }
            }
        }
}
}
