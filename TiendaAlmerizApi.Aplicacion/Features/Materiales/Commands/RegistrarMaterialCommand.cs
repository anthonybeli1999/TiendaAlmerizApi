using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Aplicacion.Features.Materiales.Commands
{
    public class RegistrarMaterialCommand : IRequest<int>
    {
        public string DescripcionMaterial { get; set; }
        public string UsuarioRegistro { get; set; }
    }
}
