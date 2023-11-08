using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Dominio.Dtos.PR;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Pedidos.Queries
{
    public static class PedidoMap
    {
        /// <summary>
        /// Metodo de mapeo de entidad a dto
        /// </summary>
        /// <param name="agencia">Entidad Agencia</param>
        /// <returns>AgenciaVm</returns>
        public static DtoPedido MapearEntidadADto(Pedido pedido)
        {
            return new DtoPedido
            {
                IdPedido = pedido.IdPedido,
                Cantidad = pedido.Cantidad,
                MontoTotal = pedido.MontoTotal,
                MetodoPago = pedido.MetodoPago,
                IdCliente = pedido.IdCliente,
                IndicadorEstado = pedido.IndicadorEstado,
                FechaPedido = pedido.FechaPedido,
                FechaRegistro = pedido.FechaRegistro,
                UsuarioRegistro = pedido.UsuarioRegistro
            };
        }
    }
}
