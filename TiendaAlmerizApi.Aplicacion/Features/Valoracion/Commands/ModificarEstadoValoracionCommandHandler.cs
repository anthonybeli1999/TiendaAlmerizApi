using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Core.Repositorios;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Valoracion.Commands
{
    public class ModificarEstadoValoracionCommandHandler : IRequestHandler<ModificarEstadoValoracionCommand, int>
    {
        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;

        public ModificarEstadoValoracionCommandHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }

        public async Task<int> Handle(ModificarEstadoValoracionCommand request,
            CancellationToken cancellationToken)
        {
            var valoracion = _repositorioOperacionGeneral
                .ObtenerPorCodigo<Valoraciones>(request.IdValoracion);

            valoracion.InactivarValoracion();
            _repositorioOperacionGeneral.GuardarCambios();

            return valoracion.IdValoracion;
        }
    }
}