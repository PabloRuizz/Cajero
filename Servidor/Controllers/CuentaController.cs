using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Servidor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentaController : ControllerBase
    {
        // GET: api/<CuentaController>
        [HttpGet]
        public IEnumerable<string> Getui()
        {

            return null;
            //return FileManager.get();
        }

        // GET api/<CuentaController>/5
        [HttpGet("id")]
        public string Get([FromQuery]string id)
        {
            string[] resultado=FileManager.getLinea(id);
            return FileManager.crearLinea(resultado[0], resultado[1], resultado[2]);

        }

        [HttpGet("all")]
        public String[] Get()
        {
            return FileManager.get();
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
