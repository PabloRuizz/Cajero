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
            string[] resultado=FileManager.getLineaId(id);
            return FileManager.crearLinea(resultado[0], resultado[1], resultado[2]);

        }

        [HttpGet("nombre")]
        public string GetNombre([FromQuery] string nombre)
        {
            string[] resultado=FileManager.getLineaNombre(nombre);
            return FileManager.crearLinea(resultado[0], resultado[1], resultado[2]);
        }

        [HttpGet("Comprobar dinero")]
        public string GetDinero([FromQuery] string id)
        {
            string[] resultado=FileManager.getLineaId(id);
            return resultado[2];
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
        public void Delete(string id)
        {
            FileManager.eliminarLinea(id);
        }

        [HttpPut("DineroAñadirConNombre")]
        public void AñadirNombre([FromQuery] string nombre, [FromQuery] int cantidad)
        {
            string[] resultado = FileManager.getLineaNombre(nombre);
            FileManager.meterDinero(resultado[0], cantidad);
        }
    }
}
