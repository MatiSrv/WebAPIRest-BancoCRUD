using Microsoft.AspNetCore.Mvc;
using Aplicacion.Servicios;
using Aplicacion.Dominio;
using Aplicacion.Servicios.Interfaces;
using Aplicacion.Servicios.Implementacion;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BancoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentasController : ControllerBase
    {
        private IServicio service;

         public CuentasController()
        {
            service = new Servicio();
        }

        // GET: api/<CuentasController>
        [HttpGet]
        public List<Cuenta> Get()
        {
            return service.Cuentas();
        }

        [HttpGet("TipoCuenta")]
        public List<Cuenta> GetCtaTC(string tc)
        {
            return service.Cargar_CuentasTC(tc);
        }

        [HttpGet("Cliente")]
        public List<Cuenta> GetCtaCli(int dni)
        {
            return service.Cargar_CuentasCLI(dni);
        }

        [HttpGet("Fechas")]
        public List<Cuenta> GetCtaFec(DateTime desde, DateTime hasta)
        {
            return service.Cargar_CuentasFEC(desde,hasta);
        }

        // POST api/<CuentasController>
        [HttpPost]
        public IActionResult post(Cuenta cuenta)
        {
            if (cuenta != null)
            {
                bool result = service.AltaCta(cuenta);
                return Ok(result);
            }
            return BadRequest("Parametro cuenta Requerido");
        }

        

        // DELETE api/<CuentasController>/5
        [HttpDelete("{cta}")]
        public IActionResult Delete(int cta)
        {
            try
            {
                bool result = service.BajaCuenta(cta);
                return Ok(result);
            }
            catch
            {
                return BadRequest("Parametro Cliente Requerido");

            }
        }
    }
}
