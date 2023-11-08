using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Dominio.Dtos.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Clientes.Queries
{
    public class ObtenerClientesQuery : IRequest<IEnumerable<DtoCliente>>
    {
    }
}
