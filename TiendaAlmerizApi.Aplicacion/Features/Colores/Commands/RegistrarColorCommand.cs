using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Aplicacion.Features.Colores.Commands
{
    public class RegistrarColorCommand : IRequest<int>
    {
        public string DescripcionColor { get; set; }
        public string UsuarioRegistro { get; set; }
    }
}
