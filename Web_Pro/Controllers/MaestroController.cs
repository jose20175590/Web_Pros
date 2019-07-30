using Microsoft.AspNetCore.Mvc;
using Model;
using Service;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    public class MaestroController : ControllerBase
    {
        private readonly IMaestroService _maestroService;
        public MaestroController(IMaestroService maestroService)
        {
            _maestroService = maestroService;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_maestroService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(
                _maestroService.Get(id)
            );
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Maestro model)
        {
            return Ok(
                _maestroService.Add(model)
                );
        }

        // PUT api/values/5
        [HttpPost]
        public IActionResult Put([FromBody] Maestro model)
        {
            return Ok(
                _maestroService.Add(model)
                );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(
                _maestroService.Delete(id)
                );
        }
    }
}
