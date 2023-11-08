using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Dominio.Dtos.PR
{
    public class DtoPedido
    {
        /// <summary>
        /// Id de la pedido
        /// </summary>
        public int IdPedido { get;  set; }

        /// <summary>
        /// Indicador estado
        /// </summary>
        public string IndicadorEstado { get;  set; }

        /// <summary>
        /// Cantidad de productos
        /// </summary>
        public int Cantidad { get;  set; }

        /// <summary>
        /// monto total de compra
        /// </summary>
        public int MontoTotal { get;  set; }

        /// <summary>
        /// metodo de pago
        /// </summary>
        public string MetodoPago { get;  set; }

        /// <summary>
        /// Fecha pedido
        /// </summary>
        public DateTime FechaPedido { get;  set; }


        /// <summary>
        /// Id del cliente
        /// </summary>
        public int IdCliente { get;  set; }

        /// <summary>
        /// Fecha registro
        /// </summary>
        public DateTime FechaRegistro { get;  set; }

        /// <summary>
        /// Usuario registro
        /// </summary>
        public string UsuarioRegistro { get;  set; }

       
    }
}
