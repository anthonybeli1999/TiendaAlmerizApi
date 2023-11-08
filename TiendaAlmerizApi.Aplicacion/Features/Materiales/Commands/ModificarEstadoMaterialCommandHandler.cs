using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Core.Repositorios;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Materiales.Commands
{
    public class ModificarEstadoMaterialCommandHandler : IRequestHandler<ModificarEstadoMaterialCommand, int>
    {
        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;

        public ModificarEstadoMaterialCommandHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }

        public async Task<int> Handle(ModificarEstadoMaterialCommand request,
            CancellationToken cancellationToken)
        {
            var material = _repositorioOperacionGeneral
                .ObtenerPorCodigo<Material>(request.IdMaterial);

            material.InactivarMaterial();
            _repositorioOperacionGeneral.GuardarCambios();

            return material.IdMaterial;
        }
    }
}
