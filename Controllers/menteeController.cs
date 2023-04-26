using mentoring_system.model;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace apimentoringsystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class menteeController : ControllerBase
    {
        public static List<mentee> menteeData = new List<mentee>
        {
            new mentee("Alice Jones", "alicejones", "password123", "23"),
            new mentee("Bob Smith", "bobsmith", "password456", "27"),
            new mentee("Charlie Brown", "charliebrown", "password789", "21")
        };

        // Pre-condition: Semua data mentee yang dibuat harus memiliki informasi yang valid dan lengkap, seperti nama, username, password, dan usia.
        // Inputan yang diterima oleh API harus divalidasi sebelum digunakan untuk mencegah kesalahan atau serangan dari pengguna jahat.
        [HttpGet]
        public IEnumerable<mentee> Get()
        {
            Debug.Assert(menteeData != null, "Mentee Data should not be null");
            return menteeData;
        }

        // Exception: Jika ID mentee yang diminta tidak ditemukan dalam database, kembalikan respons HTTP 404 (Not Found).
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

            return NotFound();
        }

        // Pre-condition: Inputan yang diterima oleh API harus divalidasi sebelum digunakan untuk mencegah kesalahan atau serangan dari pengguna jahat.
        // Exception: Jika inputan yang diberikan oleh pengguna tidak valid atau tidak lengkap, kembalikan respons HTTP 400 (Bad Request).
        [HttpPost]
        public IActionResult Post([FromBody] mentee value)
        {
            Debug.Assert(value != null, "Value should not be null");

            if (ModelState.IsValid)
            {
                menteeData.Add(value);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // Pre-condition: Inputan yang diterima oleh API harus divalidasi sebelum digunakan untuk mencegah kesalahan atau serangan dari pengguna jahat.
        // Exception: Jika ID mentee yang diminta tidak ditemukan dalam database, kembalikan respons HTTP 404 (Not Found).
        // Exception: Jika inputan yang diberikan oleh pengguna tidak valid atau tidak lengkap, kembalikan respons HTTP 400 (Bad Request).
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] mentee value)
        {
            Debug.Assert(id > 0, "Id should be greater than zero");
            Debug.Assert(value != null, "Value should not be null");

            if (ModelState.IsValid)
            {
                for (int i = 0; i < menteeData.Count; i++)
                {
                    if (menteeData[i].Id == id)
                    {
                        menteeData[i] = value;
                        return Ok();
                    }
                }

                return NotFound();
            }
            else
            {
                return BadRequest();
            }
        }
        // Exception: Jika ID mentee yang diminta tidak ditemukan dalam database, kembalikan respons HTTP 404 (Not Found).
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Debug.Assert(id > 0, "Id should be greater than zero");

            for (int i = 0; i < menteeData.Count; i++)
            {
                if (menteeData[i].Id == id)
                {
                    menteeData.RemoveAt(i);
                    return Ok();
                }
            }

            return NotFound();
        }
    }
    }

