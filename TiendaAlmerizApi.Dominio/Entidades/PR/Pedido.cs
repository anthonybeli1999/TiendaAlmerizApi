using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Dominio.Entidades.PR
{
    public class Pedido
    {
        /// <summary>
        /// Id de la pedido
        /// </summary>
        public int IdPedido { get; private set; }

        /// <summary>
        /// Indicador estado
        /// </summary>
        public string IndicadorEstado { get; private set; }

        /// <summary>
        /// Cantidad de productos
        /// </summary>
        public int Cantidad { get; private set; }

        /// <summary>
        /// monto total de compra
        /// </summary>
        public int MontoTotal { get; private set; }

        /// <summary>
        /// metodo de pago
        /// </summary>
        public string MetodoPago { get; private set; }

        /// <summary>
        /// Fecha pedido
        /// </summary>
        public DateTime FechaPedido { get; private set; }


        /// <summary>
        /// Id del cliente
        /// </summary>
        public int IdCliente { get; private set; }

        /// <summary>
        /// Fecha registro
        /// </summary>
        public DateTime FechaRegistro { get; private set; }

        /// <summary>
        /// Usuario registro
        /// </summary>
        public string UsuarioRegistro { get; private set; }

        /// <summary>
        /// Fecha modificacion
        /// </summary>
        public DateTime FechaModificacion { get; private set; }

        /// <summary>
        /// Usuario modificacion
        /// </summary>
        public string UsuarioModificacion { get; private set; }

        public static Pedido Crear(int Cantidad, int MontoTotal,string MetodoPago, int IdCliente,
            string usuarioRegistro)
        {
            return new Pedido
            {
                Cantidad = Cantidad,
                MontoTotal = MontoTotal,
                IdCliente = IdCliente,
                MetodoPago = MetodoPago,
                IndicadorEstado = "A",
                UsuarioRegistro = usuarioRegistro,
                UsuarioModificacion = usuarioRegistro,
                FechaRegistro = DateTime.Now,
                FechaModificacion = DateTime.Now
            };
        }

        public void InactivarPedido()
        {
            IndicadorEstado = "I";
            FechaModificacion = DateTime.Now;
            UsuarioModificacion = "RBELIZARIO";
        }
    }
}