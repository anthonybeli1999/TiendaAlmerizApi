using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Aplicacion.Features.Pedidos.Commands
{
    public class RegistrarPedidoCommand : IRequest<int>
    {
        public int Cantidad { get; set; }
        public int MontoTtotal { get; set; }
        public string MetodoPago { get; set; }
        public int IdCliente { get; set; }
        public string UsuarioRegistro { get; set; }
    }
}
