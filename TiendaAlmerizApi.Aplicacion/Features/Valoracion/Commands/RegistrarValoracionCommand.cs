using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Aplicacion.Features.Valoracion.Commands
{
    public class RegistrarValoracionCommand : IRequest<int>
    {
        public string Comentario { get; set; }
        public int Puntaje { get; set; }
        public int IdCliente{ get; set; }
        public string UsuarioRegistro { get; set; }
    }
}
