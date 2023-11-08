using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Aplicacion.Features.Materiales.Commands
{
    public class ModificarEstadoMaterialCommand : IRequest<int>
    {
        public int IdMaterial { get; set; }
    }
}
