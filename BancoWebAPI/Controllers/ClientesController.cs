using Aplicacion.Dominio;
using Aplicacion.Servicios.Implementacion;
using Aplicacion.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BancoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private IServicio service;

        public ClientesController()
        {
            service = new Servicio();
        }
        // GET: api/<ClienteController>
        [HttpGet]
        public List<Cliente> Get()
        {
            return service.ListClientes();
        }



        // POST api/<ClienteController>
        [HttpPost]
        public IActionResult post(Cliente cliente)
        {
            if (cliente != null)
            {
                bool result = service.AltaCli(cliente);
                return Ok(result);
            }
            return BadRequest("Parametro Cliente Requerido");
        }

        // PUT api/<ClienteController>/5
        [HttpPut]
        public IActionResult Put(Cliente cliente)
        {
            if (cliente != null)
            {
                bool result = service.Modificacion(cliente);
                return Ok(result);
            }
            return BadRequest("Parametro Cliente Requerido");
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int dni)
        {
            try
            {
                bool result = service.BajaCliente(dni);
                return Ok(result);
            }
            catch
            {
                return BadRequest("Parametro Cliente Requerido");

            }
        }
    }
}
