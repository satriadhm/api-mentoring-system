using mentoring_system.model;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace apimentoringsystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class menteeController : ControllerBase
    {
        public static List<mentee> menteeData = new List<mentee>();

        [HttpGet]
        public IEnumerable<mentee> Get()
        {
            Debug.Assert(menteeData != null, "Mentee Data should not be null");
            return menteeData;
        }

        [HttpGet("{id}")]
        public mentee? Get(int id)
        {
            Debug.Assert(id > 0, "Id should be greater than zero");

            for (int i = 0; i < menteeData.Count; i++)
            {
                if (menteeData[i].Id == id)
                {
                    return menteeData[i];
                }
            }

            return null;
        }

        [HttpPost]
        public void Post([FromBody] mentee value)
        {
            Debug.Assert(value != null, "Value should not be null");
            menteeData.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] mentee value)
        {
            Debug.Assert(id > 0, "Id should be greater than zero");
            Debug.Assert(value != null, "Value should not be null");

            for (int i = 0; i < menteeData.Count; i++)
            {
                if (menteeData[i].Id == id)
                {
                    menteeData[i] = value;
                    return;
                }
            }

            Debug.Fail("Mentee with specified id not found.");
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Debug.Assert(id > 0, "Id should be greater than zero");

            for (int i = 0; i < menteeData.Count; i++)
            {
                if (menteeData[i].Id == id)
                {
                    menteeData.RemoveAt(i);
                    return;
                }
            }

            Debug.Fail("Mentee with specified id not found.");
        }
    }
}
