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
    public class ModificarEstadoColorCommandHandler : IRequestHandler<ModificarEstadoColorCommand, int>
    {
        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;

        public ModificarEstadoColorCommandHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }

        public async Task<int> Handle(ModificarEstadoColorCommand request,
            CancellationToken cancellationToken)
        {
            var color = _repositorioOperacionGeneral
                .ObtenerPorCodigo<Color>(request.IdColor);

            color.InactivarColor();
            _repositorioOperacionGeneral.GuardarCambios();

            return color.IdColor;
        }
    }
}
