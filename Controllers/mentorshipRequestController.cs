    using mentoring_system.model;
    using Microsoft.AspNetCore.Mvc;

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
                mentorshipRequests.Add(value);
            }

            // PUT api/<mentorshipController>/5
            [HttpPut("{id}")]
            public void Put(int id, [FromBody] MentorshipRequest value)
            {
                for (int i = 0; i < mentorshipRequests.Count; i++)
                {
                    if (mentorshipRequests[i].Id == id)
                    {
                        mentorshipRequests[i] = value;
                    }
                }
            }

            // DELETE api/<mentorshipController>/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
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
