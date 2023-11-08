using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Aplicacion.Features.Categorias.Commands
{
    public class RegistrarCategoriaCommand : IRequest<int>
    {
        public string DescripcionCategoria { get; set; }
        public string UsuarioRegistro { get; set; }
    }
}
