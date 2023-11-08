using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Core.Repositorios;
using TiendaAlmerizApi.Dominio.Dtos.PR;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Categorias.Queries
{
    public class ObtenerCategoriaQueryHandler : IRequestHandler<ObtenerCategoriaQuery,
      IEnumerable<DtoCategoria>>
    {

        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;


        public ObtenerCategoriaQueryHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }


        public async Task<IEnumerable<DtoCategoria>> Handle(ObtenerCategoriaQuery request,
            CancellationToken cancellationToken)
        {
            var categorias = _repositorioOperacionGeneral
                .Listar<Categoria>().ToList();
            return categorias
                .ConvertAll(c => CategoriaMap.MapearEntidadADto(c));
        }

       
    }
}
