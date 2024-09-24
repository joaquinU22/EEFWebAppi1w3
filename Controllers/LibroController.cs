using EEFWebAppi1w3.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EEFWebAppi1w3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private ILibroRepository _libroRepository;
        public LibroController(ILibroRepository libroRepository)
        {
            _libroRepository = libroRepository;     
        }
        // GET: api/<LibroController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_libroRepository.GetAll());
            }
            catch (Exception)
            {

                return StatusCode(500, "Ocurrio un error interno: {ex.Message}");
            }
        }

        // GET api/<LibroController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LibroController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LibroController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LibroController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
