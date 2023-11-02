using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Aplicacion.Features.Colores.Commands
{
    public class ModificarEstadoColorCommand : IRequest<int>
    {
        public int IdColor { get; set; }
    }
}
