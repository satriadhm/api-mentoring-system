using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentoring_system.model
{
    public class MentorshipRequest
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public DateTime? schedule { get; set; }
        public subjekMentoring subject { get; set; }

        public MentorshipRequest(string? name, DateTime? schedule, subjekMentoring subject)
        {
            Random random = new Random();
            this.name = name;
            this.schedule = schedule;
            this.subject = subject;
            this.Id = random.Next();
        }
    }
}
