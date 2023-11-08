using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Aplicacion.Features.Subcategorias.Commands
{
    public class RegistrarSubcategoriaCommand : IRequest<int>
    {
        public string DescripcionSubcategoria { get; set; }
        public int IdCategoria { get; set; }
        public string UsuarioRegistro { get; set; }
    }
}
