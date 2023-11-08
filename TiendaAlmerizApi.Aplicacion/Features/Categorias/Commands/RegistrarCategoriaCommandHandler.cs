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
    public class RegistrarCategoriaCommandHandler : IRequestHandler<RegistrarCategoriaCommand, int>
    {
        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;

        public RegistrarCategoriaCommandHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }

        public async Task<int> Handle(RegistrarCategoriaCommand request,
            CancellationToken cancellationToken)
        {
            var categoria = Categoria.Crear(request.DescripcionCategoria,
                request.UsuarioRegistro);

            var nuevoCategoria = await _repositorioOperacionGeneral
                .AdicionarAsync(categoria);
            _repositorioOperacionGeneral.GuardarCambios();

            return nuevoCategoria.IdCategoria;
        }
    }
}