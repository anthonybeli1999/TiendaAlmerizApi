using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Aplicacion.Features.Valoraciones.Commands
{
    public class ModificarEstadoValoracionCommand : IRequest<int>
    {
        public int IdValoracion { get; set; }
    }

}
