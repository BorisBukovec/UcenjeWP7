using Microsoft.AspNetCore.Mvc;
using WebAPI9.Models;

namespace WebAPI9
{

    [ApiController]
    [Route("api/v1/[controller]")]



    public class HttpMetodeController : ControllerBase
    {

        //ovdje pocinje ruta
        // ruta je metoda

        [HttpGet]

        public string HelloWorld()
        {
            return "Boris";
        
        }
        //ovdje zavrsava ruta

        //ovdje pocinje ruta

        [HttpGet]
        [Route("Pozdrav")]

        public string HelloWorld(string ime)
        {
            return $"Hello {ime}!";
        
        }

        //ovdje zavrsava ruta

        //ovdje pocinje ruta

        [HttpGet]
        [Route("json")]

        public IActionResult GetJson(string ime, int godina)
        {
            return Ok(new { Ime = ime, Prezime = "Doe", godina = godina });
        
        }

        //ovdje zavrsava ruta

        //ovdje pocinje ruta

        [HttpPost]

        public IActionResult Post(Osoba osoba)
        {
            osoba.Ime = "Hello" + osoba.Ime;
            return StatusCode(StatusCodes.Status201Created, osoba);

        }
        //ovdje zavrsava ruta

        //ovdje pocinje ruta

        [HttpPut]
        public IActionResult Put(Osoba osoba)
        {
            osoba.Ime = "Promjenio" + osoba.Ime;
            return Ok(osoba);
        
        
        }
        //ovdje zavrsava ruta

        //ovdje pocinje ruta

        [HttpDelete]
        public IActionResult Delete(int sifra)
        {
            if (sifra <= 0)
            {
                return BadRequest(new { poruka = "Sifra mora biti veća od 0 " });
            }
            else
            {
                return Ok(new { poruka = "obrisano" });
            
            }


        }






        //ovdje zavrsava ruta
    }
}
