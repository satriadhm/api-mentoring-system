using mentoring_system.model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apimentoringsystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class menteeController : ControllerBase
    {
        public static List<mentee> menteeData = new List<mentee>();
        // GET: api/<menteeController>

        [HttpGet]
        public IEnumerable<mentee> Get()
        {
            return menteeData;
        }

        [HttpGet("{id}")]
        public mentee? Get(int id)
        {
            for (int i = 0; i < menteeData.Count; i++)
            {
                if (menteeData[i].Id == id)
                {
                    return menteeData[i];
                }
            }
            return null;
        }

        // POST api/<menteeController>
        [HttpPost]
        public void Post([FromBody] mentee value)
        {
            menteeData.Add(value);
        }

        // PUT api/<menteeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] mentee value)
        {
           for (int i = 0 ; i < menteeData.Count; i++) 
            {
                if (menteeData[i].Id == id) 
                {
                    menteeData[i] = value;
                }
            }
        }

        // DELETE api/<menteeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            for (int i = 0; i < menteeData.Count; i++)
            {
                if (menteeData[i].Id == id)
                {
                    menteeData.RemoveAt(i);        
                }
            }
            
        }
    }
}
