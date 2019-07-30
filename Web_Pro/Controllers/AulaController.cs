using Microsoft.AspNetCore.Mvc;
using Model;
using Service;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    public class AulaController : ControllerBase
    {
        private readonly IAulaService _aulaService;
        public AulaController(IAulaService aulaService)
        {
            _aulaService = aulaService;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aulaService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(
                _aulaService.Get(id)
            );
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Aula model)
        {
            return Ok(
                _aulaService.Add(model)
                );
        }

        // PUT api/values/5
        [HttpPost]
        public IActionResult Put([FromBody] Aula model)
        {
            return Ok(
                _aulaService.Add(model)
                );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(
                _aulaService.Delete(id)
                );
        }
    }
}
