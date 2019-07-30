using Microsoft.AspNetCore.Mvc;
using Model;
using Service;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]

    [ApiController]
    public class EstudianteController : ControllerBase
    {
        private readonly IEstudianteService _estudianteService;
        public EstudianteController(IEstudianteService estudianteService)
        {
            _estudianteService = estudianteService;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_estudianteService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(
                _estudianteService.Get(id)
            );
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Estudiante model)
        {
            return Ok(
                _estudianteService.Add(model)
                );
        }

        // PUT api/values/5
        [HttpPost]
        public IActionResult Put([FromBody] Estudiante model)
        {
            return Ok(
                _estudianteService.Add(model)
                );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(
                _estudianteService.Delete(id)
                );
        }
    }
}
