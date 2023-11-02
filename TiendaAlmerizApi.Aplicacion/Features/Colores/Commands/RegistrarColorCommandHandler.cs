using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Core.Repositorios;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Colores.Commands
{
    public class RegistrarColorCommandHandler : IRequestHandler<RegistrarColorCommand, int>
    {
        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;

        public RegistrarColorCommandHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base ()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }

        public async Task<int> Handle(RegistrarColorCommand request,
            CancellationToken cancellationToken)
        {
            var color = Color.Crear(request.DescripcionColor,
                request.UsuarioRegistro);

            var nuevoColor = await _repositorioOperacionGeneral
                .AdicionarAsync(color);
            _repositorioOperacionGeneral.GuardarCambios();

            return nuevoColor.IdColor;
        }
    }
}
