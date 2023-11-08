using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Aplicacion.Features.Clientes.Commands
{
    public class RegistrarClienteCommand : IRequest<int>
    {
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public int DniCliente { get; set; }
        public string DireccionenvioCliente { get; set; }
        public string EmailCliente { get; set; }
        public string ContraseñaCliente { get; set; }
        public int CelularCliente { get; set; }
        public string UsuarioRegistro { get; set; }
    }
}
