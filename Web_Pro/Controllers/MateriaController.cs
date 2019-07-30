using Microsoft.AspNetCore.Mvc;
using Model;
using Service;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    public class MateriaController : ControllerBase
    {
        private readonly IMateriaService _materiaService;
        public MateriaController(IMateriaService materiaService)
        {
            _materiaService = materiaService;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_materiaService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(
                _materiaService.Get(id)
            );
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Materia model)
        {
            return Ok(
                _materiaService.Add(model)
                );
        }

        // PUT api/values/5
        [HttpPost]
        public IActionResult Put([FromBody] Materia model)
        {
            return Ok(
                _materiaService.Add(model)
                );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(
                _materiaService.Delete(id)
                );
        }
    }
}
