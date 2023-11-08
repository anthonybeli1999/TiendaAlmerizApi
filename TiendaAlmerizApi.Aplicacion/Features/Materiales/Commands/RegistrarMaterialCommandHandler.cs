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
    public class RegistrarMaterialCommandHandler : IRequestHandler<RegistrarMaterialCommand, int>
    {
        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;

        public RegistrarMaterialCommandHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }

        public async Task<int> Handle(RegistrarMaterialCommand request,
            CancellationToken cancellationToken)
        {
            var material = Material.Crear(request.DescripcionMaterial,
                request.UsuarioRegistro);

            var nuevoMaterial = await _repositorioOperacionGeneral
                .AdicionarAsync(material);
            _repositorioOperacionGeneral.GuardarCambios();

            return nuevoMaterial.IdMaterial;
        }
    }
}
