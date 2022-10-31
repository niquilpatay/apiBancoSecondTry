using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using banco;
using DataAPI2;
using DataAPI2.fachada.interfaz;
using DataAPI2.fachada.implementacion;
using System.Data;

namespace ApiBancoSecondTry.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private iServicio dataApi;

        public ClienteController()
        {
            dataApi = new bancoServicio();
        }

        [HttpGet("/clientes")]
        public IActionResult GetClientes()
        {
            DataTable lst = null;
            try
            {
                lst = dataApi.consultarBD("cargar_Cliente");
                return Ok(lst);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Error interno, intentar luego.");
            }
        }

        [HttpPost("/clientes")]
        public IActionResult PostCliente(Cliente c)
        {
            try
            {
                if(c == null)
                {
                    return BadRequest("Datos de cliente incorrectos.");
                }
                return Ok(dataApi.actualizarBD_SP2();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
