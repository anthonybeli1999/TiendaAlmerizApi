using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Aplicacion.Features.Categorias.Queries;
using TiendaAlmerizApi.Core.Repositorios;
using TiendaAlmerizApi.Dominio.Dtos.PR;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Subcategorias.Queries
{
    public class ObtenerSubcategoriasQueryHandler : IRequestHandler<ObtenerSubcategoriasQuery,
      IEnumerable<DtoSubcategoria>>
    {

        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;


        public ObtenerSubcategoriasQueryHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }


        public async Task<IEnumerable<DtoSubcategoria>> Handle(ObtenerSubcategoriasQuery request,
            CancellationToken cancellationToken)
        {
            var subcategorias = _repositorioOperacionGeneral
                .Listar<Subcategoria>().ToList();
            return subcategorias
                .ConvertAll(c => SubcategoriaMap.MapearEntidadADto(c));
        }


    }
}
