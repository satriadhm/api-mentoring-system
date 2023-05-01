using mentoring_system.model;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apimentoringsystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mentorshipRequestController : ControllerBase
    {
        public static List<MentorshipRequest> mentorshipRequests = new List<MentorshipRequest>();

        // GET: api/<mentorshipController>
        [HttpGet]
        public IEnumerable<MentorshipRequest> Get()
        {
            return mentorshipRequests;
        }

        // GET api/<mentorshipController>/5
        [HttpGet("{id}")]
        public MentorshipRequest? Get(int id)
        {
            Debug.Assert(id >= 0, "ID should be non-negative"); // Precondition

            for (int i = 0; i < mentorshipRequests.Count; i++)
            {
                if (mentorshipRequests[i].Id == id)
                {
                    return mentorshipRequests[i];
                }
            }
            return null;
        }

        // POST api/<mentorshipController>
        [HttpPost]
        public void Post([FromBody] MentorshipRequest value)
        {
            Debug.Assert(value != null, "Mentorship request should not be null"); // Precondition

            mentorshipRequests.Add(value);

            Debug.Assert(mentorshipRequests.Contains(value), "Mentorship request should be added successfully"); // Postcondition
        }

        // PUT api/<mentorshipController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MentorshipRequest value)
        {
            Debug.Assert(id >= 0, "ID should be non-negative"); // Precondition
            Debug.Assert(value != null, "Mentorship request should not be null"); // Precondition

            for (int i = 0; i < mentorshipRequests.Count; i++)
            {
                if (mentorshipRequests[i].Id == id)
                {
                    mentorshipRequests[i] = value;
                }
            }

            Debug.Assert(mentorshipRequests.Contains(value), "Mentorship request should be updated successfully"); // Postcondition
        }

        // DELETE api/<mentorshipController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Debug.Assert(id >= 0, "ID should be non-negative"); // Precondition

            for (int i = 0; i < mentorshipRequests.Count; i++)
            {
                if (mentorshipRequests[i].Id == id)
                {
                    mentorshipRequests.RemoveAt(i);
                }
            }
        }
    }
}
