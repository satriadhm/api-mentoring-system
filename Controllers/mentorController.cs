using mentoring_system.model;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

// Untuk informasi lebih lanjut mengenai mengaktifkan Web API untuk proyek yang kosong, kunjungi https://go.microsoft.com/fwlink/?LinkID=397860

namespace apimentoringsystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mentorController : ControllerBase
    {
        public static List<mentor> mentorData = new List<mentor>
        {
            new mentor("John Doe", "johndoe", "password123", "35", subjekMentoring.interactionDesign),
            new mentor("Jane Smith", "janesmith", "password456", "28", subjekMentoring.dataStructure),
            new mentor("Bob Johnson", "bobjohnson", "password789", "42", subjekMentoring.Algorithm)
        };

        // Pra-kondisi: id yang diberikan haruslah bilangan bulat positif
        // Post-kondisi: Mengembalikan data mentor dengan id sesuai yang diberikan, jika tidak ditemukan maka mengembalikan null
        [HttpGet("{id}")]
        public mentor? Get(int id)
        {
            Debug.Assert(id > 0, "ID haruslah bilangan bulat positif");

            for (int i = 0; i < mentorData.Count; i++)
            {
                if (mentorData[i].Id == id)
                {
                    return mentorData[i];
                }
            }

            return null;
        }

        // Pra-kondisi: -
        // Post-kondisi: Mengembalikan seluruh data mentor yang ada
        [HttpGet]
        public IEnumerable<mentor> Get()
        {
            return mentorData;
        }

        // Pra-kondisi: -
        // Post-kondisi: Menambahkan data mentor baru ke dalam mentorData
        [HttpPost]
        public void Post([FromBody] mentor value)
        {
            Debug.Assert(value != null, "Data mentor tidak boleh kosong");

            mentorData.Add(value);
        }

        // Pra-kondisi: id yang diberikan haruslah bilangan bulat positif
        // Post-kondisi: Mengubah nilai data mentor dengan id yang diberikan
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] mentor value)
        {
            Debug.Assert(id > 0, "ID haruslah bilangan bulat positif");
            Debug.Assert(value != null, "Data mentor tidak boleh kosong");

            for (int i = 0; i < mentorData.Count; i++)
            {
                if (mentorData[i].Id == id)
                {
                    mentorData[i] = value;
                }
            }
        }

        // Pra-kondisi: id yang diberikan haruslah bilangan bulat positif
        // Post-kondisi: Menghapus data mentor dengan id yang diberikan
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Debug.Assert(id > 0, "ID haruslah bilangan bulat positif");

            for (int i = 0; i < mentorData.Count; i++)
            {
                if (mentorData[i].Id == id)
                {
                    mentorData.RemoveAt(i);
                }
            }
        }
    }
}
