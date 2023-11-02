using MediatR;
using TiendaAlmerizApi.Logging.Interfaz;
using TiendaAlmerizApi.Aplicacion.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TiendaAlmerizApi.Dominio.Dtos.PR;
using TiendaAlmerizApi.Aplicacion.Features.Colores.Queries;
using TiendaAlmerizApi.Aplicacion.Features.Colores.Commands;

namespace TiendaAlmerizApi.Controllers
{
    //https://localhost:7026/api/Productos/colores
    //https://localhost:7026/api/Productos/
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : BaseController<ProductosController>
    {
        public ProductosController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        [Route("colores")]
        [ProducesResponseType(typeof(IEnumerable<DtoColores>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<DtoColores>>> ObtenerColores()
        {
            var comando = new ObtenerColoresQuery();
            var resultado = await OperationMediator(comando);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }

        [HttpPost]
        [Route("color")]
        public async Task<ActionResult<long>> RegistrarColor([FromBody] RegistrarColorCommand command)
        {
            var resultado = await OperationMediator(command);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }

        [HttpPut]
        [Route("color")]
        public async Task<ActionResult<long>> ModificarEstadoColor([FromBody] ModificarEstadoColorCommand command)
        {
            var resultado = await OperationMediator(command);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }
    }
}
