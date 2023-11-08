using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Core.Repositorios;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Subcategorias.Commands
{
    public class ModificarEstadoSubcategoriaCommandHandler : IRequestHandler<ModificarEstadoSubcategoriaCommand, int>
    {
        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;

        public ModificarEstadoSubcategoriaCommandHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }

        public async Task<int> Handle(ModificarEstadoSubcategoriaCommand request,
            CancellationToken cancellationToken)
        {
            var subcategoria = _repositorioOperacionGeneral
                .ObtenerPorCodigo<Subcategoria>(request.IdSubcategoria);

            subcategoria.InactivarSubcategoria();
            _repositorioOperacionGeneral.GuardarCambios();

            return subcategoria.IdSubcategoria;
        }
    }
}