using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Core.Repositorios;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Categorias.Commands
{
    public class ModificarEstadoCategoriaCommandHandler : IRequestHandler<ModificarEstadoCategoriaCommand, int>
    {
        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;

        public ModificarEstadoCategoriaCommandHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }

        public async Task<int> Handle(ModificarEstadoCategoriaCommand request,
            CancellationToken cancellationToken)
        {
            var categoria = _repositorioOperacionGeneral
                .ObtenerPorCodigo<Categoria>(request.IdCategoria);

            categoria.InactivarColor();
            _repositorioOperacionGeneral.GuardarCambios();

            return categoria.IdCategoria;
        }
    }
}
