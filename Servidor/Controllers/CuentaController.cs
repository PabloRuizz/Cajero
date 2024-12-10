using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Servidor.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class CuentaController : ControllerBase
    {
        // GET: api/<CuentaController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CuentaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CuentaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CuentaController>/5
        [HttpPut("DineroAñadirId")]
        public void Añadir([FromQuery] string id, [FromQuery] int cantidad)
        {
            FileManager.meterDinero(id, cantidad);
        }

        // PUT api/<CuentaController>/5
        [HttpPut("DineroRetirarId")]
        public void Retirar([FromQuery] string id, [FromQuery] int cantidad)
        {
            FileManager.sacarDinero(id, cantidad);
        }

        // DELETE api/<CuentaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
