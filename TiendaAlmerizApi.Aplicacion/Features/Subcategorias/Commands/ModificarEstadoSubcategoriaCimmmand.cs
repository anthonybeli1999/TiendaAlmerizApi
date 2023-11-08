using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Aplicacion.Features.Subcategorias.Commands
{
    public class ModificarEstadoSubcategoriaCommand : IRequest<int>
    {
        public int IdSubcategoria { get; set; }
    }
}
