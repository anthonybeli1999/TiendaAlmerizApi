using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Aplicacion.Features.Clientes.Commands
{
    public class ModificarEstadoClienteCommand : IRequest<int>
    {
        public int IdCliente { get; set; }
    }
}
