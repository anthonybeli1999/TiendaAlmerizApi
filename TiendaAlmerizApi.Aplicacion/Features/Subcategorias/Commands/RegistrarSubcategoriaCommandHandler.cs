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
    public class RegistrarSubcategoriaCommandHandler : IRequestHandler<RegistrarSubcategoriaCommand, int>
    {
        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;

        public RegistrarSubcategoriaCommandHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }

        public async Task<int> Handle(RegistrarSubcategoriaCommand request,
            CancellationToken cancellationToken)
        {
            var subcategoria = Subcategoria.Crear(request.DescripcionSubcategoria,request.IdCategoria,
                request.UsuarioRegistro);

            var nuevoSubcategoria = await _repositorioOperacionGeneral
                .AdicionarAsync(subcategoria);
            _repositorioOperacionGeneral.GuardarCambios();

            return nuevoSubcategoria.IdSubcategoria;
        }
    }
}