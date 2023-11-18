using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Core.Repositorios;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Valoraciones.Commands
{
    public class RegistrarValoracionCommandHandler : IRequestHandler<RegistrarValoracionCommand, int>
    {
        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;

        public RegistrarValoracionCommandHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }

        public async Task<int> Handle(RegistrarValoracionCommand request,
            CancellationToken cancellationToken)
        {
            var valoracion = Valoracion.Crear(request.Comentario,request.Puntaje, request.IdCliente,
                request.UsuarioRegistro);

            var nuevoValoracion = await _repositorioOperacionGeneral
                .AdicionarAsync(valoracion);
            _repositorioOperacionGeneral.GuardarCambios();

            return nuevoValoracion.IdValoracion;
        }
    }
}