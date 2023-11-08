using MediatR;
using TiendaAlmerizApi.Logging.Interfaz;
using TiendaAlmerizApi.Aplicacion.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TiendaAlmerizApi.Dominio.Dtos.PR;
using TiendaAlmerizApi.Aplicacion.Features.Colores.Queries;
using TiendaAlmerizApi.Aplicacion.Features.Colores.Commands;
using TiendaAlmerizApi.Aplicacion.Features.Materiales.Queries;
using TiendaAlmerizApi.Aplicacion.Features.Materiales.Commands;
using TiendaAlmerizApi.Aplicacion.Features.Categorias.Commands;
using TiendaAlmerizApi.Aplicacion.Features.Categorias.Queries;
using TiendaAlmerizApi.Aplicacion.Features.Clientes.Queries;
using TiendaAlmerizApi.Aplicacion.Features.Clientes.Commands;
using TiendaAlmerizApi.Aplicacion.Features.Subcategorias.Queries;
using TiendaAlmerizApi.Aplicacion.Features.Subcategorias.Commands;
using TiendaAlmerizApi.Aplicacion.Features.Valoracion.Queries;
using TiendaAlmerizApi.Aplicacion.Features.Valoracion.Commands;
using TiendaAlmerizApi.Aplicacion.Features.Pedidos.Queries;
using TiendaAlmerizApi.Aplicacion.Features.Pedidos.Commands;

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
        #region
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
        #endregion

        #region
        //RUTA PARA MATERIAL
        [HttpGet]
        [Route("materiales")]
        [ProducesResponseType(typeof(IEnumerable<DtoMaterial>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<DtoMaterial>>> ObtenerMateriales()
        {
            var comando = new ObtenerMaterialesQuery();
            var resultado = await OperationMediator(comando);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }

        [HttpPost]
        [Route("material")]
        public async Task<ActionResult<long>> RegistrarMaterial([FromBody] RegistrarMaterialCommand command)
        {
            var resultado = await OperationMediator(command);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }

        [HttpPut]
        [Route("material")]
        public async Task<ActionResult<long>> ModificarEstadoMaterial([FromBody] ModificarEstadoMaterialCommand command)
        {
            var resultado = await OperationMediator(command);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }
        #endregion

        #region
        //RUTA PARA CATEGORIA
        [HttpGet]
        [Route("categorias")]
        [ProducesResponseType(typeof(IEnumerable<DtoCategoria>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<DtoCategoria>>> ObtenerCategorias()
        {
            var comando = new ObtenerCategoriaQuery();
            var resultado = await OperationMediator(comando);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }

        [HttpPost]
        [Route("categoria")]
        public async Task<ActionResult<long>> RegistrarCategoria([FromBody] RegistrarCategoriaCommand command)
        {
            var resultado = await OperationMediator(command);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }

        [HttpPut]
        [Route("categoria")]
        public async Task<ActionResult<long>> ModificarEstadoCategoria([FromBody] ModificarEstadoCategoriaCommand command)
        {
            var resultado = await OperationMediator(command);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }
        #endregion

        #region
        //RUTA PARA SUBCATEGORIA
        [HttpGet]
        [Route("subcategorias")]
        [ProducesResponseType(typeof(IEnumerable<DtoSubcategoria>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<DtoSubcategoria>>> ObtenerSubcategorias()
        {
            var comando = new ObtenerSubcategoriasQuery();
            var resultado = await OperationMediator(comando);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }

        [HttpPost]
        [Route("subcategoria")]
        public async Task<ActionResult<long>> RegistrarSubcategoria([FromBody] RegistrarSubcategoriaCommand command)
        {
            var resultado = await OperationMediator(command);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }

        [HttpPut]
        [Route("subcategoria")]
        public async Task<ActionResult<long>> ModificarEstadoSubcategoria([FromBody] ModificarEstadoSubcategoriaCommand command)
        {
            var resultado = await OperationMediator(command);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }
        #endregion

        #region
        //RUTA PARA CLIENTE
        [HttpGet]
        [Route("clientes")]
        [ProducesResponseType(typeof(IEnumerable<DtoCliente>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<DtoCliente>>> ObtenerClientes()
        {
            var comando = new ObtenerClientesQuery();
            var resultado = await OperationMediator(comando);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }

        [HttpPost]
        [Route("cliente")]
        public async Task<ActionResult<long>> RegistrarCliente([FromBody] RegistrarClienteCommand command)
        {
            var resultado = await OperationMediator(command);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }

        [HttpPut]
        [Route("cliente")]
        public async Task<ActionResult<long>> ModificarEstadoCliente([FromBody] ModificarEstadoClienteCommand command)
        {
            var resultado = await OperationMediator(command);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }
        #endregion

        #region
        //RUTA PARA VALORACION
        [HttpGet]
        [Route("valoraciones")]
        [ProducesResponseType(typeof(IEnumerable<DtoValoracion>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<DtoValoracion>>> ObtenerValoraciones()
        {
            var comando = new ObtenerValoracionesQuery();
            var resultado = await OperationMediator(comando);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }

        [HttpPost]
        [Route("valoracion")]
        public async Task<ActionResult<long>> RegistrarValoracion([FromBody] RegistrarValoracionCommand command)
        {
            var resultado = await OperationMediator(command);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }

        [HttpPut]
        [Route("valoracion")]
        public async Task<ActionResult<long>> ModificarEstadoValoracion([FromBody] ModificarEstadoValoracionCommand command)
        {
            var resultado = await OperationMediator(command);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }
        #endregion


        #region
        //RUTA PARA PEDIDOS
        [HttpGet]
        [Route("pedidos")]
        [ProducesResponseType(typeof(IEnumerable<DtoPedido>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<DtoPedido>>> ObtenerPedidos()
        {
            var comando = new ObtenerPedidosQuery();
            var resultado = await OperationMediator(comando);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }

        [HttpPost]
        [Route("pedido")]
        public async Task<ActionResult<long>> RegistrarPedido([FromBody] RegistrarPedidoCommand command)
        {
            var resultado = await OperationMediator(command);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }

        [HttpPut]
        [Route("pedido")]
        public async Task<ActionResult<long>> ModificarEstadoPedido([FromBody] ModificarEstadoPedidoCommand command)
        {
            var resultado = await OperationMediator(command);
            if (resultado.Resultado)
                return Ok(resultado.Datos);
            return BadRequest(resultado.Errores);
        }
        #endregion
    }
}
